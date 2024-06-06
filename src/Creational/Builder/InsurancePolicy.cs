namespace DesignPatterns.Creational.Builder;

public class InsurancePolicy
{
    public string PolicyType { get; set; }
    public double Premium { get; set; }
    public double CoverAmount { get; set; }

    public override string ToString()
    {
        return $"Policy Type: {PolicyType}, Premium: {Premium:C0}, Cover Amount: {CoverAmount:C0}";
    }
}