namespace DesignPatterns.Structural.Decorator;

public class CarInsurancePolicy : IInsurancePolicy
{
    private readonly double _premium;

    public CarInsurancePolicy(double premium)
    {
        _premium = premium;
    }

    public string GetDetails()
    {
        return $"Car Insurance with premium: {_premium}";
    }

    public double GetPremium()
    {
        return _premium;
    }
}