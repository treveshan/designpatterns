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
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("Enter the type of insurance policy (Health, Life, Vehicle) or Exit:");
            var policyType = Console.ReadLine();

            IPolicyCreator creator = null
                ;

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
                case "Exit":
                    exit = true;
                    return;
                default:
                    Console.WriteLine("Invalid policy type.");
                    break;
            }

            if (creator is not null)
            {
                IPolicy policy = creator.CreatePolicy();
                Console.WriteLine($"Created policy type: {policy.GetPolicyType()}");
            }
        }

    }
}