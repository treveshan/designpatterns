using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Proxy;

public class Proxy
{
    private readonly IOutput _output;

    public Proxy(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        IInsuranceService service = new InsuranceServiceProxy();

        var firstCall = service.GetPolicyDetails("P12345");
        var secondCall = service.GetPolicyDetails("P12345");

        _output.Display(firstCall);
        _output.Display(secondCall);
    }
}
