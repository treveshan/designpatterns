namespace DesignPatterns.Structural.Bridge;

public class HealthInsurancePolicy : IInsurancePolicy
{
    private readonly IInsuranceProvider _provider;

    public HealthInsurancePolicy(IInsuranceProvider provider)
    {
        _provider = provider;
    }

    public string GetPolicyDetails()
    {
        return "Health Insurance Policy Details";
    }

    public string IssuePolicy()
    {
        return _provider.IssuePolicy("Health");
    }
}