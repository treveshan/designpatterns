using DesignPatterns.Structural.Proxy;
using FluentAssertions;
using NSubstitute;

namespace DesignPatterns.Structural.Tests;

public class ProxyPatternTests
{
    [Test]
    public void ShouldCachePolicyDetails()
    {
        var realService = Substitute.For<IInsuranceService>();
        realService.GetPolicyDetails("P100").Returns("cached");
        var proxy = new InsuranceServiceProxy(realService);

        var first = proxy.GetPolicyDetails("P100");
        var second = proxy.GetPolicyDetails("P100");

        first.Should().Be("cached");
        second.Should().Be("cached");
        realService.Received(1).GetPolicyDetails("P100");
    }

    [Test]
    public void ShouldCallRealServiceForDifferentIds()
    {
        var realService = Substitute.For<IInsuranceService>();
        realService.GetPolicyDetails("A").Returns("A");
        realService.GetPolicyDetails("B").Returns("B");
        var proxy = new InsuranceServiceProxy(realService);

        proxy.GetPolicyDetails("A");
        proxy.GetPolicyDetails("B");

        realService.Received(1).GetPolicyDetails("A");
        realService.Received(1).GetPolicyDetails("B");
    }
}

