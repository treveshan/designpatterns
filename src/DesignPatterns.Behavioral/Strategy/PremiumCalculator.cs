namespace DesignPatterns.Behavioral.Strategy;

public class PremiumCalculator
{
    private IPremiumStrategy _strategy;

    public PremiumCalculator(IPremiumStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IPremiumStrategy strategy) => _strategy = strategy;

    public decimal Calculate(decimal amount) => _strategy.Calculate(amount);
}
