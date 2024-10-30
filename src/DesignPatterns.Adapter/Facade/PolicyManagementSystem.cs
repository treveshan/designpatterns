namespace DesignPatterns.Structural.Facade;

public class PolicyManagementSystem
{
    public string CreatePolicy(string policyId, string policyType)
    {
        return $"Creating policy {policyId} of type {policyType}.";
    }

    public string GetPolicyDetails(string policyId)
    {
        return $"Retrieving details for policy {policyId}.";
    }
}