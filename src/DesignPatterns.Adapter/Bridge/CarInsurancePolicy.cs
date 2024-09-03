namespace DesignPatterns.Structural.Bridge;

public class CarInsurancePolicy : IInsurancePolicy
{
    private readonly IInsuranceProvider _provider;

    public CarInsurancePolicy(IInsuranceProvider provider)
    {
        _provider = provider;
    }

    public string GetPolicyDetails()
    {
        return "Car Insurance Policy Details";
    }

    public string IssuePolicy()
    {
        return _provider.IssuePolicy("Car");
    }
}