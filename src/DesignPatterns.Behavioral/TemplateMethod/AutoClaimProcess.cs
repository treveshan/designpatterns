namespace DesignPatterns.Behavioral.TemplateMethod;

public class AutoClaimProcess : ClaimProcessTemplate
{
    protected override void Validate() { }

    protected override decimal CalculateAmount() => 500m;
}
