using DesignPatterns.Creational.FactoryMethod.PolicyTypes;

namespace DesignPatterns.Creational.FactoryMethod.PolicyCreators;

public class VehiclePolicyCreator : IPolicyCreator
{
    public IPolicy CreatePolicy() => new VehiclePolicy();
}