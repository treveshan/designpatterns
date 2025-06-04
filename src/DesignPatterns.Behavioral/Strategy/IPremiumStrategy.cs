namespace DesignPatterns.Behavioral.Strategy;

public interface IPremiumStrategy
{
    decimal Calculate(decimal baseAmount);
}
