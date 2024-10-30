namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class PaymentAdminTwo : IClaimHandler
{
    public IClaimHandler SetNext(IClaimHandler nextHandler)
    {
        // No next handler because PaymentAdminTwo is the last in the chain
        return nextHandler;
    }

    public ClaimProcessingResult ProcessClaim(Claim claim)
    {
        if (claim.Type == "Payment")
        {
            if (claim.Amount > 11999)
            {
                return new ClaimProcessingResult(false, "Claim Admin Two could not process the claim and there are no further handlers.");

            }
            return new ClaimProcessingResult(true, $"Payment Admin Two approved the {claim}");
        }
        else
        {
            return new ClaimProcessingResult(false, "Request type not handled by Payment Admin Two.");
        }
    }
}