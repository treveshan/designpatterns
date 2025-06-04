using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy;

public class InMemoryPolicyCache : IPolicyCache
{
    private readonly Dictionary<string, string> _cache = new();

    public bool TryGetPolicy(string policyId, out string info)
    {
        return _cache.TryGetValue(policyId, out info!);
    }

    public void SetPolicy(string policyId, string info)
    {
        _cache[policyId] = info;
    }
}
