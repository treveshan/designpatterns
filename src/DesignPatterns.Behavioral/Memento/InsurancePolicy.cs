namespace DesignPatterns.Behavioral.Memento;

public class InsurancePolicy
{
    public int Coverage { get; private set; }

    public InsurancePolicy(int coverage)
    {
        Coverage = coverage;
    }

    public PolicyMemento Save() => new PolicyMemento(Coverage);

    public void Restore(PolicyMemento memento)
    {
        Coverage = memento.Coverage;
    }
}
