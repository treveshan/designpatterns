using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Visitor;

public class Visitor
{
    private readonly IOutput _output;

    public Visitor(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var policies = new IInsurancePolicy[] { new CarPolicy(), new HomePolicy() };
        var visitor = new PremiumVisitor();
        foreach (var p in policies)
            p.Accept(visitor);
        _output.Display($"Total: {visitor.Total}");
    }
}
