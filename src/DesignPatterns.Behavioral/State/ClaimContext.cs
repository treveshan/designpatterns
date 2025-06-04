namespace DesignPatterns.Behavioral.State;

public class ClaimContext
{
    public IClaimState State { get; private set; }

    public ClaimContext()
    {
        State = new SubmittedState();
    }

    public void Next() => State.Next(this);

    public void SetState(IClaimState state) => State = state;
}
