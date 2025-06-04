using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Interpreter;

public class Interpreter
{
    private readonly IOutput _output;

    public Interpreter(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var result = RpnInterpreter.Evaluate("3 4 + 2 -");
        _output.Display($"Result: {result}");
    }
}
