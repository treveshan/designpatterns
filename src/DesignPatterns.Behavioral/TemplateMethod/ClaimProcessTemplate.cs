namespace DesignPatterns.Behavioral.TemplateMethod;

public abstract class ClaimProcessTemplate
{
    public string Process()
    {
        Validate();
        var amount = CalculateAmount();
        Save();
        return $"Amount: {amount}";
    }

    protected abstract void Validate();
    protected abstract decimal CalculateAmount();
    protected virtual void Save() { }
}
