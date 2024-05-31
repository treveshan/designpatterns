using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Car;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Health;
using DesignPatterns.Creational.AbstractFactory.PolicyTypes.Home;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public interface IInsurancePolicyFactory
{
    IHealthInsurancePolicy CreateHealthInsurancePolicy();
    ICarInsurancePolicy CreateCarInsurancePolicy();
    IHomeInsurancePolicy CreateHomeInsurancePolicy();
}