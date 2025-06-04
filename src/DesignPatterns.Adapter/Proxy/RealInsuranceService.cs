namespace DesignPatterns.Structural.Proxy;

public class RealInsuranceService : IInsuranceService
{
    private readonly Dictionary<string, string> _policies = new()
    {
        {"P100", "Policy 100 Details"},
        {"P200", "Policy 200 Details"}
    };

    public int CallCount { get; private set; }

    public string GetPolicyDetails(string policyId)
    {
        CallCount++;
        return _policies.TryGetValue(policyId, out var details)
            ? details
            : $"Policy {policyId} not found";
    }
}
