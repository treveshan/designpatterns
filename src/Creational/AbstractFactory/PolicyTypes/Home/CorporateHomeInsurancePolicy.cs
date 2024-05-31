namespace DesignPatterns.Creational.AbstractFactory.PolicyTypes.Home;

public class CorporateHomeInsurancePolicy : IHomeInsurancePolicy
{
    public string GetDetails()
    {
        return "Corporate Home Insurance Policy Details";
    }
}