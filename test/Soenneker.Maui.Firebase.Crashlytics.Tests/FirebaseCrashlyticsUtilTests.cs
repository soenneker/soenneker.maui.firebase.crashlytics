using Soenneker.Tests.HostedUnit;

namespace Soenneker.Maui.Firebase.Crashlytics.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class FirebaseCrashlyticsUtilTests : HostedUnitTest
{

    public FirebaseCrashlyticsUtilTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
