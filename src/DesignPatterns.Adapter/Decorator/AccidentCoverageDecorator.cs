namespace DesignPatterns.Structural.Decorator;

public class AccidentCoverageDecorator : IInsurancePolicyDecorator
{
    private readonly double _additionalPremium;

    public AccidentCoverageDecorator(IInsurancePolicy policy, double additionalPremium)
    {
        Policy = policy;
        _additionalPremium = additionalPremium;
    }

    public IInsurancePolicy Policy { get; }

    public string GetDetails()
    {
        return $"{Policy.GetDetails()} + Accident Coverage";
    }

    public double GetPremium()
    {
        return Policy.GetPremium() + _additionalPremium;
    }
}