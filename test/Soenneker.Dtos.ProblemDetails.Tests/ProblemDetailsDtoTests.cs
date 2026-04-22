using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.ProblemDetails.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class ProblemDetailsDtoTests : HostedUnitTest
{
    public ProblemDetailsDtoTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
