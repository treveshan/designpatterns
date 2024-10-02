using System.Text;

namespace DesignPatterns.Structural.Composite;

public class InsurancePackage : IInsuranceComponent
{
    private readonly List<IInsuranceComponent> _components = new List<IInsuranceComponent>();

    public void AddComponent(IInsuranceComponent component)
    {
        _components.Add(component);
    }

    public void RemoveComponent(IInsuranceComponent component)
    {
        _components.Remove(component);
    }

    public string GetDetails()
    {
        var details = new StringBuilder("Insurance Package:\n");
        foreach (var component in _components)
        {
            details.AppendLine($"  - {component.GetDetails()}");
        }
        return details.ToString();
    }

    public double GetPremium()
    {
        return _components.Sum(c => c.GetPremium());
    }
}