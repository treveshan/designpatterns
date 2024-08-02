namespace DesignPatterns.Structural.Adapter;

public interface IInsurancePolicy
{
    string GetPolicyDetails();
    double CalculatePremium(double baseAmount, int age, bool hasAccidents);
}