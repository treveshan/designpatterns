namespace DesignPatterns.Creational.AbstractFactory.PolicyTypes.Home;

public class IndividualHomeInsurancePolicy : IHomeInsurancePolicy
{
    public string GetDetails()
    {
        return "Individual Home Insurance Policy Details";
    }
}