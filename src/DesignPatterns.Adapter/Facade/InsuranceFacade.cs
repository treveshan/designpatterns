namespace DesignPatterns.Structural.Facade;

public class InsuranceFacade
{
    private readonly ClaimProcessingSystem _claimProcessingSystem;
    private readonly PolicyManagementSystem _policyManagementSystem;
    private readonly PaymentProcessingSystem _paymentProcessingSystem;

    public InsuranceFacade()
    {
        _claimProcessingSystem = new ClaimProcessingSystem();
        _policyManagementSystem = new PolicyManagementSystem();
        _paymentProcessingSystem = new PaymentProcessingSystem();
    }

    public string CreateNewPolicy(string policyId, string policyType)
    {
        var result = _policyManagementSystem.CreatePolicy(policyId, policyType);
        return $"---- Creating a new policy ----\n{result}\nPolicy creation completed.";
    }

    public string MakeClaim(string policyId, double claimAmount)
    {
        var result = _claimProcessingSystem.ProcessClaim(policyId, claimAmount);
        return $"---- Processing a new claim ----\n{result}\nClaim processing completed.";
    }

    public string MakePayment(string policyId, double paymentAmount)
    {
        var result = _paymentProcessingSystem.ProcessPayment(policyId, paymentAmount);
        return $"---- Processing a payment ----\n{result}\nPayment processing completed.";
    }

    public string GetPolicyInfo(string policyId)
    {
        var policyDetails = _policyManagementSystem.GetPolicyDetails(policyId);
        var paymentStatus = _paymentProcessingSystem.CheckPaymentStatus(policyId);
        return $"---- Retrieving policy information ----\n{policyDetails}\n{paymentStatus}\nPolicy information retrieval completed.";
    }
}