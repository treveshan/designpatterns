namespace DesignPatterns.Structural.Flyweight;

//Extrinsic State: This represents the unique state
public class InsurancePolicy
{
    private readonly InsuranceType _insuranceType;
    public string CustomerName { get; }
    public string PolicyNumber { get; }

    public InsurancePolicy(InsuranceType insuranceType, string customerName, string policyNumber)
    {
        _insuranceType = insuranceType;
        CustomerName = customerName;
        PolicyNumber = policyNumber;
    }

    public string GetPolicyDetails()
    {
        return $"Policy No: {PolicyNumber}, Customer: {CustomerName}, {_insuranceType.GetPolicyTypeDetails()}";
    }
}