namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public interface IClaimHandler
{
    IClaimHandler SetNext(IClaimHandler nextHandler);
    ClaimProcessingResult ProcessClaim(Claim claim);
}