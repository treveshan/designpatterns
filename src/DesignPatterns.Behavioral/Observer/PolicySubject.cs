namespace DesignPatterns.Behavioral.Observer;

public class PolicySubject
{
    private readonly List<IPolicyObserver> _observers = new();

    public void Attach(IPolicyObserver observer) => _observers.Add(observer);
    public void Detach(IPolicyObserver observer) => _observers.Remove(observer);

    public void Notify(string policyId)
    {
        foreach (var o in _observers)
            o.Update(policyId);
    }
}
