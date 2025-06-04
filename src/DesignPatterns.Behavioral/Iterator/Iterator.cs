using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Iterator;

public class Iterator
{
    private readonly IOutput _output;

    public Iterator(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var policies = new PolicyCollection();
        policies.Add(new InsurancePolicy("A"));
        policies.Add(new InsurancePolicy("B"));

        foreach (var p in policies)
        {
            _output.Display($"Policy: {p.Id}");
        }
    }
}
