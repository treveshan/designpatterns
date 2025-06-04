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
        var realService = new RealInsuranceService();
        IInsuranceService proxy = new InsuranceServiceProxy(realService);

        _output.Display(proxy.GetPolicyDetails("P100"));
        _output.Display(proxy.GetPolicyDetails("P100"));
        _output.Display($"Calls to real service: {realService.CallCount}");
    }
}
