using Soenneker.Tests.HostedUnit;

namespace Soenneker.PlanetScale.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PlanetScaleOpenApiClientTests : HostedUnitTest
{
    public PlanetScaleOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
