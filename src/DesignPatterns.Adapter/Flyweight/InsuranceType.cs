namespace DesignPatterns.Structural.Flyweight;

//Intrinsic State: This represents the shared state
public class InsuranceType
{
    public string Type { get; }
    public string Coverage { get; }

    public InsuranceType(string type, string coverage)
    {
        Type = type;
        Coverage = coverage;
    }

    public string GetPolicyTypeDetails()
    {
        return $"Type: {Type}, Coverage: {Coverage}";
    }
}