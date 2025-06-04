namespace DesignPatterns.Behavioral.Visitor;

public interface IInsurancePolicy
{
    void Accept(IPolicyVisitor visitor);
}
