namespace DesignPatterns.Creational.AbstractFactory.PolicyTypes.Car;

public class CorporateCarInsurancePolicy : ICarInsurancePolicy
{
    public string GetDetails()
    {
       return "Corporate Car Insurance Policy Details";
    }
}