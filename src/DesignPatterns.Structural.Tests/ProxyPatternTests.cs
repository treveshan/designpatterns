using DesignPatterns.Structural.Proxy;
using FluentAssertions;

namespace DesignPatterns.Structural.Tests;

public class ProxyPatternTests
{
    private class StubPolicyService : IPolicyService
    {
        public int CallCount { get; private set; }

        public string GetPolicyInfo(string policyId)
        {
            CallCount++;
            return $"Policy Info for {policyId}";
        }
    }

    [Test]
    public void GetPolicyInfo_ShouldStoreResultInCache()
    {
        // Arrange
        var realService = new StubPolicyService();
        var cache = new InMemoryPolicyCache();
        var proxy = new InsurancePolicyServiceProxy(realService, cache);

        // Act
        var result = proxy.GetPolicyInfo("P123");

        // Assert
        result.Should().Be("Policy Info for P123");
        cache.TryGetPolicy("P123", out var cached).Should().BeTrue();
        cached.Should().Be("Policy Info for P123");
        realService.CallCount.Should().Be(1);
    }

    [Test]
    public void GetPolicyInfo_ShouldUseCachedValueOnSubsequentCalls()
    {
        // Arrange
        var realService = new StubPolicyService();
        var cache = new InMemoryPolicyCache();
        var proxy = new InsurancePolicyServiceProxy(realService, cache);

        // Act
        var first = proxy.GetPolicyInfo("P123");
        var second = proxy.GetPolicyInfo("P123");

        // Assert
        first.Should().Be("Policy Info for P123");
        second.Should().Be("Policy Info for P123");
        realService.CallCount.Should().Be(1);
    }
}
