namespace DesignPatterns.Creational.AbstractFactory.PolicyTypes.Health;

public class IndividualHealthInsurancePolicy : IHealthInsurancePolicy
{
    public string GetDetails()
    {
        return "Individual Health Insurance Policy Details";
    }
}