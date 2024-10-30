namespace DesignPatterns.Structural.Facade;

public class ClaimProcessingSystem
{
    public string ProcessClaim(string policyId, double amount)
    {
        return $"Processing claim for policy {policyId} with amount ${amount}.";
    }
}