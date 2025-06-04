namespace DesignPatterns.Structural.Proxy;

public class InsuranceServiceProxy : IInsuranceService
{
    private readonly IInsuranceService _realService;
    private readonly Dictionary<string, string> _cache = new();

    public InsuranceServiceProxy(IInsuranceService realService)
    {
        _realService = realService;
    }

    public string GetPolicyDetails(string policyId)
    {
        if (_cache.TryGetValue(policyId, out var cached))
        {
            return cached;
        }

        var details = _realService.GetPolicyDetails(policyId);
        _cache[policyId] = details;
        return details;
    }
}
