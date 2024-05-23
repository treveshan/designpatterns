using DesignPatterns.Creational.FactoryMethod.PolicyTypes;

namespace DesignPatterns.Creational.FactoryMethod.PolicyCreators;

public class LifePolicyCreator : IPolicyCreator
{
    public IPolicy CreatePolicy() => new LifePolicy();
}