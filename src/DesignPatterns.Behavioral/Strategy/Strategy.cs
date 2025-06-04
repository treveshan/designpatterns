using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Strategy;

public class Strategy
{
    private readonly IOutput _output;

    public Strategy(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var calc = new PremiumCalculator(new BasicStrategy());
        _output.Display($"Basic: {calc.Calculate(100)}");
        calc.SetStrategy(new DiscountStrategy());
        _output.Display($"Discount: {calc.Calculate(100)}");
    }
}
