using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.TemplateMethod;

public class TemplateMethod
{
    private readonly IOutput _output;

    public TemplateMethod(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        ClaimProcessTemplate process = new AutoClaimProcess();
        _output.Display(process.Process());
    }
}
