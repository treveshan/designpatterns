namespace DesignPatterns.Structural.Decorator;

public interface IInsurancePolicyDecorator : IInsurancePolicy
{
    IInsurancePolicy Policy { get; }
}