namespace DesignPatterns.Structural.Proxy;

public interface IPolicyCache
{
    bool TryGetPolicy(string policyId, out string info);
    void SetPolicy(string policyId, string info);
}
