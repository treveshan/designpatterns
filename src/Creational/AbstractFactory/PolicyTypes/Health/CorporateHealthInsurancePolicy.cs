namespace DesignPatterns.Creational.AbstractFactory.PolicyTypes.Health;

public class CorporateHealthInsurancePolicy : IHealthInsurancePolicy
{
    public string GetDetails()
    {
       return "Corporate Health Insurance Policy Details";
    }
}