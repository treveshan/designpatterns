namespace DesignPatterns.Structural.Bridge;

public interface IInsurancePolicy
{
    string GetPolicyDetails();
    string IssuePolicy();
}