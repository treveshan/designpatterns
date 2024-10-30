namespace DesignPatterns.Structural.Facade;

public class PaymentProcessingSystem
{
    public string ProcessPayment(string policyId, double amount)
    {
        return $"Processing payment for policy {policyId} with amount ${amount}.";
    }

    public string CheckPaymentStatus(string policyId)
    {
        return $"Checking payment status for policy {policyId}.";
    }
}