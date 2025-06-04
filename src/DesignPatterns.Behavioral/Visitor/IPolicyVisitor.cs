namespace DesignPatterns.Behavioral.Visitor;

public interface IPolicyVisitor
{
    void Visit(CarPolicy car);
    void Visit(HomePolicy home);
}
