namespace DesignPatterns.Behavioral.Strategy;

public class BasicStrategy : IPremiumStrategy
{
    public decimal Calculate(decimal baseAmount) => baseAmount;
}
