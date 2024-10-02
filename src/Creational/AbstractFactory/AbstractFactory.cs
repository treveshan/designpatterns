using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Car;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Health;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Home;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Creational.AbstractFactory;

public class AbstractFactory
{
    private readonly IOutput _output;

    public AbstractFactory(IOutput output)
    {
        _output = output;
    }

    public void Run(string option)
    {
        //Advantages
        // Flexibility in adding new product types
        // Simplifies code maintenance
        // Promotes loose coupling

        //Disadvantages
        // Can introduce complexity with many subclasses
        // Overhead in creating multiple classes

        switch (option)
        {
            case "Individual":
                IInsurancePolicyFactory individualFactory = new IndividualInsurancePolicyFactory();

                IHealthInsurancePolicy individualHealthPolicy = individualFactory.CreateHealthInsurancePolicy();
                _output.Display(individualHealthPolicy.GetDetails());

                ICarInsurancePolicy individualCarPolicy = individualFactory.CreateCarInsurancePolicy();
                _output.Display(individualCarPolicy.GetDetails());

                IHomeInsurancePolicy individualHomePolicy = individualFactory.CreateHomeInsurancePolicy();
                _output.Display(individualHomePolicy.GetDetails());

                break;
            case "Corporate":
                IInsurancePolicyFactory corporateFactory = new CorporateInsurancePolicyFactory();

                IHealthInsurancePolicy corporateHealthPolicy = corporateFactory.CreateHealthInsurancePolicy();
                _output.Display(corporateHealthPolicy.GetDetails());

                ICarInsurancePolicy corporateCarPolicy = corporateFactory.CreateCarInsurancePolicy();
                _output.Display(corporateCarPolicy.GetDetails());

                IHomeInsurancePolicy corporateHomePolicy = corporateFactory.CreateHomeInsurancePolicy();
                _output.Display(corporateHomePolicy.GetDetails());
                break;
            default:
                _output.Display("Invalid option.");
                break;
        }


    }
}
