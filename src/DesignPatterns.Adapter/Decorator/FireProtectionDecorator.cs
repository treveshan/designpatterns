namespace DesignPatterns.Structural.Decorator;

public class FireProtectionDecorator : IInsurancePolicyDecorator
{
    private readonly double _additionalPremium;

    public FireProtectionDecorator(IInsurancePolicy policy, double additionalPremium)
    {
        Policy = policy;
        _additionalPremium = additionalPremium;
    }

    public IInsurancePolicy Policy { get; }

    public string GetDetails()
    {
        return $"{Policy.GetDetails()} + Fire Protection";
    }

    public double GetPremium()
    {
        return Policy.GetPremium() + _additionalPremium;
    }
}