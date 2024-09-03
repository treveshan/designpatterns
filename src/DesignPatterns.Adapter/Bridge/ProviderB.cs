namespace DesignPatterns.Structural.Bridge;

public class ProviderB : IInsuranceProvider
{
    public string IssuePolicy(string policyType)
    {
        return $"Provider B: Issuing {policyType} policy.";
    }
}