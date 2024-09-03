namespace DesignPatterns.Structural.Bridge;

public class ProviderA : IInsuranceProvider
{
    public string IssuePolicy(string policyType)
    {
        return $"Provider A: Issuing {policyType} policy.";
    }
}