using DesignPatterns.Creational.FactoryMethod.PolicyCreators;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Creational.FactoryMethod;

public class FactoryMethod
{
    private readonly IOutput _output;

    public FactoryMethod(IOutput output)
    {
        _output = output;
    }

    public void Run(string policyType)
    {
        //Advantages
        // Flexibility in adding new product types
        // Simplifies code maintenance
        // Promotes loose coupling

        //Disadvantages
        // Can introduce complexity with many subclasses
        // Overhead in creating multiple classes

        IPolicyCreator creator = null;
        switch (policyType)
        {
            case "Health":
                creator = new HealthPolicyCreator();
                break;
            case "Life":
                creator = new LifePolicyCreator();
                break;
            case "Vehicle":
                creator = new VehiclePolicyCreator();
                break;
            default:
                _output.Display("Invalid policy type.");
                break;
        }

        if (creator is not null)
        {
            IPolicy policy = creator.CreatePolicy();
            _output.Display($"Created policy type: {policy.GetPolicyType()}");
        }

    }
}
