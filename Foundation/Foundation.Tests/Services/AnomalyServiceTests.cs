using FluentAssertions;
using Foundation.Anomalies;
using NSubstitute;

namespace Foundation.Tests.Services;

public class AnomalyServiceTests : TestDataBuilder
{
    [Fact]
    public void Invoke_AnomalyRepository_When_GetAll()
    {
        var repository = Substitute.For<IAnomalyRepository>();
        var service = new AnomalyService(repository);

        service.GetAll();

        repository.Received().GetAll();
    }

    [Fact]
    public async void Return_All_Anomalies_From_AnomalyRepository_When_GetAll()
    {
        var expected = CreateTestAnomalies();
        var repository = Substitute.For<IAnomalyRepository>();
        repository.GetAll().Returns(expected);

        var service = new AnomalyService(repository);

        var anomalies = await service.GetAll();

        anomalies.Should().Contain(expected);
    }
}