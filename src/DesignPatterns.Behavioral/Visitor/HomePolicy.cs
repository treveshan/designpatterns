namespace DesignPatterns.Behavioral.Visitor;

public class HomePolicy : IInsurancePolicy
{
    public decimal Premium => 500m;
    public void Accept(IPolicyVisitor visitor) => visitor.Visit(this);
}
