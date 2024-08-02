namespace DesignPatterns.Structural.Adapter;

public class LegacyInsuranceSystem
{
    public string GetLegacyPolicyDetails()
    {
        return "Legacy Policy Details: Type=Comprehensive, Premium=1500, CoverAmount=500000, Benefits=Benefit1;Benefit2";
    }



    public double CalculateLegacyPremium(string policyType, double baseAmount, int age, bool hasAccidents)
    {
        double premium = baseAmount;
        if (policyType == "Comprehensive")
        {
            premium += 500;
        }
        if (age < 25)
        {
            premium += 200;
        }
        if (hasAccidents)
        {
            premium += 300;
        }
        return premium;
    }
}