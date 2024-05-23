using DesignPatterns.Creational.FactoryMethod.PolicyCreators;

namespace DesignPatterns.Creational.FactoryMethod;

public class RunFactoryMethodExample
{
    public void Run()
    {
        //Advantages
        // Flexibility in adding new product types
        // Simplifies code maintenance
        // Promotes loose coupling

        //Disadvantages
        // Can introduce complexity with many subclasses
        // Overhead in creating multiple classes

        Console.WriteLine("Enter the type of insurance policy (Health, Life, Vehicle):");
        var policyType = Console.ReadLine();

        IPolicyCreator creator;

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
                Console.WriteLine("Invalid policy type.");
                return;
        }

        IPolicy policy = creator.CreatePolicy();
        Console.WriteLine($"Created policy type: {policy.GetPolicyType()}");
    }
}