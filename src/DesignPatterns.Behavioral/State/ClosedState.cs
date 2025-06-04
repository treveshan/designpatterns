namespace DesignPatterns.Behavioral.State;

public class ClosedState : IClaimState
{
    public string Status => "Closed";

    public void Next(ClaimContext context)
    {
        // final state
    }
}
