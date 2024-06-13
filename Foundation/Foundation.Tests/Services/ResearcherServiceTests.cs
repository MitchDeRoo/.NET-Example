using FluentAssertions;
using Foundation.Repositories;
using Foundation.Services;
using NSubstitute;

namespace Foundation.Tests.Services;

public class ResearcherServiceTests : TestDataBuilder
{
    [Fact]
    public void Invokes_ResearcherRepository_When_GetAll()
    {
        var repository = Substitute.For<IResearcherRepository>();
        var service = new ResearcherService(repository);

        service.GetAll();

        repository.Received().GetAll();
    }

    [Fact]
    public async void Return_All_Anomalies_From_AnomalyRepository_When_GetAll()
    {
        var expected = CreateTestResearchers();
        var repository = Substitute.For<IResearcherRepository>();
        repository.GetAll().Returns(expected);

        var service = new ResearcherService(repository);

        var anomalies = await service.GetAll();

        anomalies.Should().Contain(expected);
    }
}