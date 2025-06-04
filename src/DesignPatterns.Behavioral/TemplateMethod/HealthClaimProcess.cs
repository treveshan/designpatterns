namespace DesignPatterns.Behavioral.TemplateMethod;

public class HealthClaimProcess : ClaimProcessTemplate
{
    protected override void Validate() { }

    protected override decimal CalculateAmount() => 200m;
}
