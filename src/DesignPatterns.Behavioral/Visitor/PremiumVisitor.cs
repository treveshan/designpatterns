namespace DesignPatterns.Behavioral.Visitor;

public class PremiumVisitor : IPolicyVisitor
{
    public decimal Total { get; private set; }

    public void Visit(CarPolicy car) => Total += car.Premium;
    public void Visit(HomePolicy home) => Total += home.Premium;
}
