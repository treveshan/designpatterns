namespace DesignPatterns.Creational.Builder;

public interface IInsurancePolicyBuilder
{
    IInsurancePolicyBuilder WithPolicyType(string policyType);
    IInsurancePolicyBuilder WithPremium(double premium);
    IInsurancePolicyBuilder WithCoverAmount(double coverAmount);
    InsurancePolicy Build();
}