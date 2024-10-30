namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class ClaimAdminOne : IClaimHandler
{
    private IClaimHandler _nextHandler;

    public IClaimHandler SetNext(IClaimHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public ClaimProcessingResult ProcessClaim(Claim claim)
    {
        if (claim.Type == "Claim" && claim.Amount <= 1000)
        {
            return new ClaimProcessingResult(true, $"Claim Admin One approved the {claim}");
        }
        else if (_nextHandler != null)
        {
            return _nextHandler.ProcessClaim(claim);
        }
        else
        {
            return new ClaimProcessingResult(false, "Claim Admin One could not process the claim and there are no further handlers.");
        }
    }
}