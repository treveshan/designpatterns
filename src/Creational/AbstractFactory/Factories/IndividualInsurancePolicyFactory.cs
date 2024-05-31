using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Car;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Health;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Home;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class IndividualInsurancePolicyFactory : IInsurancePolicyFactory
{
    public IHealthInsurancePolicy CreateHealthInsurancePolicy()
    {
        return new IndividualHealthInsurancePolicy();
    }

    public ICarInsurancePolicy CreateCarInsurancePolicy()
    {
        return new IndividualCarInsurancePolicy();
    }

    public IHomeInsurancePolicy CreateHomeInsurancePolicy()
    {
        return new IndividualHomeInsurancePolicy();
    }
}