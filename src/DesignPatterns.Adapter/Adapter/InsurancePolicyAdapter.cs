namespace DesignPatterns.Structural.Adapter;

public class InsurancePolicyAdapter : IInsurancePolicy
{
    private readonly LegacyInsuranceSystem _legacySystem;

    public InsurancePolicyAdapter(LegacyInsuranceSystem legacySystem)
    {
        _legacySystem = legacySystem;
    }

    public string GetPolicyDetails()
    {
        // Convert the legacy policy details to the new format
        var legacyDetails = _legacySystem.GetLegacyPolicyDetails();
        var parts = legacyDetails.Replace("Legacy Policy Details: ", "").Split(", ");
        return string.Join(", ", parts);
    }

    public double CalculatePremium(double baseAmount, int age, bool hasAccidents)
    {
        // Use the legacy system to calculate the premium
        var policyType = "Comprehensive"; // Assume this is derived from context or additional logic
        return _legacySystem.CalculateLegacyPremium(policyType, baseAmount, age, hasAccidents);
    }
}