using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Memento;

public class Memento
{
    private readonly IOutput _output;

    public Memento(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var policy = new InsurancePolicy(100);
        var saved = policy.Save();
        policy = new InsurancePolicy(200);
        policy.Restore(saved);
        _output.Display($"Coverage: {policy.Coverage}");
    }
}
