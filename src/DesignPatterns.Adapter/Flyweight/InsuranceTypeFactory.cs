namespace DesignPatterns.Structural.Flyweight;

public class InsuranceTypeFactory
{
    private readonly Dictionary<string, InsuranceType> _insuranceTypes = new Dictionary<string, InsuranceType>();

    public InsuranceType GetInsuranceType(string type, string coverage)
    {
        var key = $"{type}_{coverage}";

        if (!_insuranceTypes.ContainsKey(key))
        {
            _insuranceTypes[key] = new InsuranceType(type, coverage);
        }

        return _insuranceTypes[key];
    }
}