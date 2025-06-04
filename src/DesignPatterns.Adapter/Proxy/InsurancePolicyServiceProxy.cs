using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy;

public class InsurancePolicyServiceProxy : IPolicyService
{
    private readonly IPolicyService _realService;
    private readonly IPolicyCache _cache;

    public InsurancePolicyServiceProxy(IPolicyService realService)
        : this(realService, new InMemoryPolicyCache())
    {
    }

    public InsurancePolicyServiceProxy(IPolicyService realService, IPolicyCache cache)
    {
        _realService = realService;
        _cache = cache;
    }

    public string GetPolicyInfo(string policyId)
    {
        if (_cache.TryGetPolicy(policyId, out var info))
        {
            return info;
        }

        info = _realService.GetPolicyInfo(policyId);
        _cache.SetPolicy(policyId, info);
        return info;
    }
}
