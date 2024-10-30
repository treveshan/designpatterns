namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class ClaimAdminTwo : IClaimHandler
{
    private IClaimHandler _nextHandler;

    public IClaimHandler SetNext(IClaimHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ClaimProcessingResult ProcessClaim(Claim claim)
    {
        if (claim.Type == "Claim" && claim.Amount <= 5000)
        {
            return new ClaimProcessingResult(true, $"Claim Admin Two approved the {claim}");
        }
        else if (_nextHandler != null)
        {
            return _nextHandler.ProcessClaim(claim);
        }
        else
        {
            return new ClaimProcessingResult(false, "Claim Admin Two could not process the claim and there are no further handlers.");
        }
    }
}