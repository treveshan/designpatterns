import { IInsurancePolicyBuilder } from './IInsurancePolicyBuilder';
import { InsurancePolicy } from './InsurancePolicy';

export class InsurancePolicyDirector {
    constructComprehensive(builder: IInsurancePolicyBuilder): InsurancePolicy {
        return builder
            .withPolicyType('Comprehensive')
            .withPremium(1500.0)
            .withCoverAmount(500000.0)
            .build();
    }

    constructBasic(builder: IInsurancePolicyBuilder): InsurancePolicy {
        return builder
            .withPolicyType('Basic')
            .withPremium(500.0)
            .withCoverAmount(100000.0)
            .build();
    }
}
