using DesignPatterns.Behavioral.Iterator;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Iterator;

public class IteratorPatternTests
{
    [Test]
    public void ShouldIterateThroughPolicies()
    {
        var collection = new PolicyCollection();
        collection.Add(new InsurancePolicy("A"));
        collection.Add(new InsurancePolicy("B"));

        var ids = collection.Select(p => p.Id).ToList();

        ids.Should().ContainInOrder("A", "B");
    }
}
