namespace DesignPatterns.Creational.Prototype;

public class InsurancePolicy : IInsurancePolicyPrototype
{
    public string PolicyType { get; set; }
    public double Premium { get; set; }
    public double CoverAmount { get; set; }

    public IInsurancePolicyPrototype Clone()
    {
        return (IInsurancePolicyPrototype)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Policy Type: {PolicyType}, Premium: {Premium}, Cover Amount: {CoverAmount}";
    }
}