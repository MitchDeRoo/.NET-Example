using FluentAssertions;
using Foundation.Controllers;
using Foundation.Models;
using Foundation.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace Foundation.Tests.Controllers;

public class AnomalyControllerTests : TestDataBuilder
{
    private readonly IAnomalyService _service;
    private readonly AnomalyController _controller;

    public AnomalyControllerTests()
    {
        _service = Substitute.For<IAnomalyService>();
        _controller = new AnomalyController(_service);
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
        List<Anomaly> expectedItems = [
            CreateAnomaly("SCP-173", "Euclid", "Statue made of rebar, concrete and spray paint"),
            CreateAnomaly("SCP-999", "Safe", "Cute orange-yellow slime made of happiness"),
            CreateAnomaly("SCP-682", "Keter", "Hard To Destroy Reptile")
        ];
        _service.GetAll().Returns(expectedItems);

        var result = await _controller.Get() as OkObjectResult;

        var items = result.Value as IEnumerable<Anomaly>;
        items.Should().Contain(expectedItems);
    }
}