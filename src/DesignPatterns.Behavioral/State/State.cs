using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.State;

public class State
{
    private readonly IOutput _output;

    public State(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var context = new ClaimContext();
        _output.Display(context.State.Status);
        context.Next();
        _output.Display(context.State.Status);
        context.Next();
        _output.Display(context.State.Status);
    }
}
