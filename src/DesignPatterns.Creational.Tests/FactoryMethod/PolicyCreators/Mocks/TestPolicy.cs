using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators.Mocks;

public class TestPolicy : IPolicy
{
    public string GetPolicyType() => "Test Insurance";
}