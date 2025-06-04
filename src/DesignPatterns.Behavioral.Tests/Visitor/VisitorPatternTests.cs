using DesignPatterns.Behavioral.Visitor;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Visitor;

public class VisitorPatternTests
{
    [Test]
    public void PremiumVisitor_ShouldCalculateTotal()
    {
        var policies = new IInsurancePolicy[] { new CarPolicy(), new HomePolicy() };
        var visitor = new PremiumVisitor();
        foreach (var p in policies)
            p.Accept(visitor);

        visitor.Total.Should().Be(800m);
    }
}
