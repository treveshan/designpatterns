namespace DesignPatterns.Structural.Proxy;

public class RealInsuranceService : IInsuranceService
{
    public int CallCount { get; private set; }

    public string GetPolicyDetails(string policyId)
    {
        CallCount++;
        return $"Policy details for {policyId}";
    }
}
