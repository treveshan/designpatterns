namespace DesignPatterns.Behavioral.Command;

public class PolicyService
{
    private readonly List<string> _policies = new();

    public string AddPolicy(string id)
    {
        _policies.Add(id);
        return $"Policy {id} added";
    }

    public string RemovePolicy(string id)
    {
        _policies.Remove(id);
        return $"Policy {id} removed";
    }

    public IReadOnlyList<string> Policies => _policies.AsReadOnly();
}
