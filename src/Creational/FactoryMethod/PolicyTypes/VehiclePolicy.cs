namespace DesignPatterns.Creational.FactoryMethod.PolicyTypes;

public class VehiclePolicy : IPolicy
{
    public string GetPolicyType() => "Vehicle Insurance";
}