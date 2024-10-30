namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class PaymentAdminOne : IClaimHandler
{
    private IClaimHandler _nextHandler;

    public IClaimHandler SetNext(IClaimHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ClaimProcessingResult ProcessClaim(Claim claim)
    {
        if (claim.Type == "Payment" && claim.Amount <= 10000)
        {
            return new ClaimProcessingResult(true, $"Payment Admin One approved the {claim}");
        }
        else if (_nextHandler != null)
        {
            return _nextHandler.ProcessClaim(claim);
        }
        else
        {
            return new ClaimProcessingResult(false, "Payment Admin One could not process the claim and there are no further handlers.");
        }
    }
}