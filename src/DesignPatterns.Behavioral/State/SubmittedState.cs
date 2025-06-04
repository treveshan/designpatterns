namespace DesignPatterns.Behavioral.State;

public class SubmittedState : IClaimState
{
    public string Status => "Submitted";

    public void Next(ClaimContext context)
    {
        context.SetState(new ApprovedState());
    }
}
