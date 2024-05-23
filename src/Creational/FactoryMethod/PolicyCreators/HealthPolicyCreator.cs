using DesignPatterns.Creational.FactoryMethod.PolicyTypes;

namespace DesignPatterns.Creational.FactoryMethod.PolicyCreators;

public class HealthPolicyCreator : IPolicyCreator
{
    public IPolicy CreatePolicy() => new HealthPolicy();
}