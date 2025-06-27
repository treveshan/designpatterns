import { InsurancePolicy } from './InsurancePolicy';

export interface IInsurancePolicyBuilder {
    withPolicyType(policyType: string): this;
    withPremium(premium: number): this;
    withCoverAmount(amount: number): this;
    build(): InsurancePolicy;
}
