namespace DesignPatterns.Creational.FactoryMethod.PolicyTypes;

public class HealthPolicy : IPolicy
{
    public string GetPolicyType() => "Health Insurance";
}