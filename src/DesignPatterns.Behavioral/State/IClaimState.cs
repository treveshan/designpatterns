namespace DesignPatterns.Behavioral.State;

public interface IClaimState
{
    void Next(ClaimContext context);
    string Status { get; }
}
