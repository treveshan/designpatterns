import { InsurancePolicy } from './InsurancePolicy';
import { IInsurancePolicyBuilder } from './IInsurancePolicyBuilder';

export class InsurancePolicyBuilder implements IInsurancePolicyBuilder {
    private policy: InsurancePolicy = new InsurancePolicy();

    withPolicyType(policyType: string): this {
        this.policy.policyType = policyType;
        return this;
    }

    withPremium(premium: number): this {
        this.policy.premium = premium;
        return this;
    }

    withCoverAmount(amount: number): this {
        this.policy.coverAmount = amount;
        return this;
    }

    build(): InsurancePolicy {
        return this.policy;
    }
}
