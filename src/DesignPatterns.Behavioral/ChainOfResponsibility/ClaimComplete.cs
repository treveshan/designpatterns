namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class ClaimComplete : IClaimHandler
{
    public IClaimHandler SetNext(IClaimHandler nextHandler)
    {
        return nextHandler;
    }

    public ClaimProcessingResult ProcessClaim(Claim claim)
    {
        return new ClaimProcessingResult(true, $"Completed: {claim}");
    }
}