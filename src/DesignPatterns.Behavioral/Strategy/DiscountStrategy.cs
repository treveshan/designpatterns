namespace DesignPatterns.Behavioral.Strategy;

public class DiscountStrategy : IPremiumStrategy
{
    public decimal Calculate(decimal baseAmount) => baseAmount * 0.9m;
}
