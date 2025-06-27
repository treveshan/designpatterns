import { InsurancePolicyBuilder } from './InsurancePolicyBuilder';
import { InsurancePolicyDirector } from './InsurancePolicyDirector';

export class Builder {
    run(policyType: string): void {
        const builder = new InsurancePolicyBuilder();
        const director = new InsurancePolicyDirector();

        let policy;
        switch (policyType) {
            case 'Comprehensive':
                policy = director.constructComprehensive(builder);
                break;
            case 'Basic':
                policy = director.constructBasic(builder);
                break;
            default:
                console.log('Invalid option.');
                return;
        }

        console.log(policy.toString());
    }
}

// If run from command line
if (require.main === module) {
    const type = process.argv[2];
    if (type) {
        new Builder().run(type);
    } else {
        console.log('Please provide policy type.');
    }
}
