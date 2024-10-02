namespace DesignPatterns.Structural.Composite;

public class HealthInsurancePolicy : IInsuranceComponent
{
    private readonly double _premium;

    public HealthInsurancePolicy(double premium)
    {
        _premium = premium;
    }

    public string GetDetails()
    {
        return $"Health Insurance with premium: {_premium}";
    }

    public double GetPremium()
    {
        return _premium;
    }
}