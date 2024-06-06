namespace DesignPatterns.Creational.Builder;

public class InsurancePolicyDirector
{
    public InsurancePolicy ConstructComprehensivePolicy(IInsurancePolicyBuilder builder)
    {
        return builder
            .WithPolicyType("Comprehensive")
            .WithPremium(1500.00)
            .WithCoverAmount(500000.00)
            .Build();
    }

    public InsurancePolicy ConstructBasicPolicy(IInsurancePolicyBuilder builder)
    {
        return builder
            .WithPolicyType("Basic")
            .WithPremium(500.00)
            .WithCoverAmount(100000.00)
            .Build();
    }
}