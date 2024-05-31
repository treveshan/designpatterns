namespace DesignPatterns.Creational.AbstractFactory.PolicyTypes.Car;

public class IndividualCarInsurancePolicy : ICarInsurancePolicy
{
    
    public string GetDetails()
    {
        return "Individual Car Insurance Policy Details";
    }
}