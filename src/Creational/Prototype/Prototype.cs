using DesignPatterns.Utils.Display;

namespace DesignPatterns.Creational.Prototype;

public class Prototype 
{
    private readonly IOutput _output;

    public Prototype(IOutput output)
    {
        _output = output;
    }

    public void Run(string policyType)
    {

        var originalPolicy = new InsurancePolicy()
        {
            PolicyType = "Comprehensive",
            Premium = 1500.00,
            CoverAmount = 500000.00
        };

        // Clone the original policy
        var clonedPolicy = originalPolicy.Clone() as InsurancePolicy;

        // Modify the cloned policy
        clonedPolicy.PolicyType = "Basic";
        clonedPolicy.Premium = 500.00;
        clonedPolicy.CoverAmount = 100000.00;

        _output.Display("Original Policy:");
        _output.Display(originalPolicy.ToString());
        _output.Display("Cloned Policy:");
        _output.Display(clonedPolicy.ToString());
    }
}
