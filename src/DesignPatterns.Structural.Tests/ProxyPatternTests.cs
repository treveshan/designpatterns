using DesignPatterns.Structural.Proxy;
using FluentAssertions;

namespace DesignPatterns.Structural.Tests;

public class ProxyPatternTests
{
    [Test]
    public void ShouldReturnPolicyDetails()
    {
        var realService = new RealInsuranceService();
        var proxy = new InsuranceServiceProxy(realService);

        var details = proxy.GetPolicyDetails("P12345");

        details.Should().Be("Policy details for P12345");
    }

    [Test]
    public void ShouldCallRealServiceOnlyOnceForSamePolicy()
    {
        var realService = new RealInsuranceService();
        var proxy = new InsuranceServiceProxy(realService);

        proxy.GetPolicyDetails("P12345");
        proxy.GetPolicyDetails("P12345");

        realService.CallCount.Should().Be(1);
    }
}
