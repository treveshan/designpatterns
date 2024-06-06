namespace DesignPatterns.Creational.Prototype;

public class InsurancePolicy : IInsurancePolicyPrototype
{
    public string PolicyType { get; set; }
    public double Premium { get; set; }
    public double CoverAmount { get; set; }
    public List<string> Benefits { get; set; } = new List<string>();

    public IInsurancePolicyPrototype Clone()
    {
        // Deep clone implementation
        var clonedPolicy = (InsurancePolicy)this.MemberwiseClone();
        clonedPolicy.Benefits = new List<string>(this.Benefits);
        return clonedPolicy;
    }

    public override string ToString()
    {
        return $"Policy Type: {PolicyType}, Premium: {Premium}, Cover Amount: {CoverAmount}, Benefits: {string.Join(", ", Benefits)}";
    }
}
