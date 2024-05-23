namespace DesignPatterns.Creational.FactoryMethod.PolicyCreators;

public interface IPolicyCreator
{
    IPolicy CreatePolicy();
}