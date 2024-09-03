namespace DesignPatterns.Structural.Bridge;

public interface IInsuranceProvider
{
    string IssuePolicy(string policyType);
}