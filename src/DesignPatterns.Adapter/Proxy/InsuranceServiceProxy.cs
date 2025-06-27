namespace DesignPatterns.Structural.Proxy;

public class InsuranceServiceProxy : IInsuranceService
{
    private readonly RealInsuranceService _realService;
    private readonly Dictionary<string, string> _cache = new();

    public InsuranceServiceProxy() : this(new RealInsuranceService())
    {
    }

    public InsuranceServiceProxy(RealInsuranceService realService)
    {
        _realService = realService;
    }

    public int RealServiceCallCount => _realService.CallCount;

    public string GetPolicyDetails(string policyId)
    {
        if (_cache.TryGetValue(policyId, out var details))
        {
            return details;
        }

        details = _realService.GetPolicyDetails(policyId);
        _cache[policyId] = details;
        return details;
    }
}
