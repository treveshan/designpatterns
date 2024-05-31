using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Car;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Health;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Home;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class CorporateInsurancePolicyFactory : IInsurancePolicyFactory
{
    public IHealthInsurancePolicy CreateHealthInsurancePolicy()
    {
        return new CorporateHealthInsurancePolicy();
    }

    public ICarInsurancePolicy CreateCarInsurancePolicy()
    {
        return new CorporateCarInsurancePolicy();
    }

    public IHomeInsurancePolicy CreateHomeInsurancePolicy()
    {
        return new CorporateHomeInsurancePolicy();
    }
}