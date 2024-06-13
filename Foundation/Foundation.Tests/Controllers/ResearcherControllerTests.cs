using FluentAssertions;
using Foundation.Controllers;
using Foundation.Models;
using Foundation.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace Foundation.Tests.Controllers;

public class ResearcherControllerTests : TestDataBuilder
{
    private readonly IResearcherService _service;
    private readonly ResearcherController _controller;

    public ResearcherControllerTests()
    {
        _service = Substitute.For<IResearcherService>();
        _controller = new ResearcherController(_service);
    }

    [Fact]
    public async Task Get_OnSuccess_Returns_StatusCode_200()
    {
        var result = await _controller.Get() as OkObjectResult;
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_Invokes_AnomalyService()
    {
        _service.GetAll().Returns([]);

        var result = await _controller.Get() as OkObjectResult;

        _service.Received().GetAll();
    }

    [Fact]
    public async Task Get_OnSuccess_Returns_List_Of_Items()
    {
        List<Researcher> expectedItems = [
            CreateResearcher("Jack", "Bright"),
            CreateResearcher("Mark", "Gears")
        ];
        _service.GetAll().Returns(expectedItems);

        var result = await _controller.Get() as OkObjectResult;

        var items = result.Value as IEnumerable<Researcher>;
        items.Should().Contain(expectedItems);
    }
}