namespace DesignPatterns.Behavioral.Observer;

public class DepartmentObserver : IPolicyObserver
{
    public List<string> Notifications { get; } = new();

    public void Update(string policyId)
    {
        Notifications.Add($"Policy {policyId} updated");
    }
}
