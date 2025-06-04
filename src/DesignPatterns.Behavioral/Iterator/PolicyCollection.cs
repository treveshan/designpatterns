namespace DesignPatterns.Behavioral.Iterator;

public class PolicyCollection : IEnumerable<InsurancePolicy>
{
    private readonly List<InsurancePolicy> _policies = new();

    public void Add(InsurancePolicy policy) => _policies.Add(policy);

    public IEnumerator<InsurancePolicy> GetEnumerator() => _policies.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
