namespace DesignPatterns.Structural.Decorator;

public class HomeInsurancePolicy : IInsurancePolicy
{
    private readonly double _premium;

    public HomeInsurancePolicy(double premium)
    {
        _premium = premium;
    }

    public string GetDetails()
    {
        return $"Home Insurance with premium: {_premium}";
    }

    public double GetPremium()
    {
        return _premium;
    }
}