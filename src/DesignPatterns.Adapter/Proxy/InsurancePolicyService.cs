namespace DesignPatterns.Structural.Proxy;

public class InsurancePolicyService : IPolicyService
{
    public string GetPolicyInfo(string policyId)
    {
        return $"Policy Info for {policyId}";
    }
}
