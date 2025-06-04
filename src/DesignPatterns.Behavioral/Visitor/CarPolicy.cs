namespace DesignPatterns.Behavioral.Visitor;

public class CarPolicy : IInsurancePolicy
{
    public decimal Premium => 300m;
    public void Accept(IPolicyVisitor visitor) => visitor.Visit(this);
}
