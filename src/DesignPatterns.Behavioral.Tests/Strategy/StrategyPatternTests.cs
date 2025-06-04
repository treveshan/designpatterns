using DesignPatterns.Behavioral.Strategy;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Strategy;

public class StrategyPatternTests
{
    [Test]
    public void Calculator_ShouldUseDifferentStrategies()
    {
        var calc = new PremiumCalculator(new BasicStrategy());
        calc.Calculate(100).Should().Be(100);
        calc.SetStrategy(new DiscountStrategy());
        calc.Calculate(100).Should().Be(90);
    }
}
