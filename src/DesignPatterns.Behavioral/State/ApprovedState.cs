namespace DesignPatterns.Behavioral.State;

public class ApprovedState : IClaimState
{
    public string Status => "Approved";

    public void Next(ClaimContext context)
    {
        context.SetState(new ClosedState());
    }
}
