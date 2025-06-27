export class InsurancePolicy {
    policyType?: string;
    premium?: number;
    coverAmount?: number;

    toString(): string {
        const premiumStr = this.premium !== undefined
            ? this.premium.toLocaleString('en-US', { style: 'currency', currency: 'USD', maximumFractionDigits: 0 })
            : '';
        const coverAmountStr = this.coverAmount !== undefined
            ? this.coverAmount.toLocaleString('en-US', { style: 'currency', currency: 'USD', maximumFractionDigits: 0 })
            : '';
        return `Policy Type: ${this.policyType}, Premium: ${premiumStr}, Cover Amount: ${coverAmountStr}`;
    }
}
