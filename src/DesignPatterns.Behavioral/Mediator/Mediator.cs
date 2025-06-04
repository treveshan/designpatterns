using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Mediator;

public class Mediator
{
    private readonly IOutput _output;

    public Mediator(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var mediator = new ChatMediator();
        var a = new Participant("Alice");
        var b = new Participant("Bob");
        mediator.Register(a);
        mediator.Register(b);

        a.Send("Hi Bob");
        b.Send("Hello Alice");

        foreach (var msg in a.Received)
            _output.Display(msg);
        foreach (var msg in b.Received)
            _output.Display(msg);
    }
}
