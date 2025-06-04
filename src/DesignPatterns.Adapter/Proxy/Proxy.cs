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
        IPolicyService realService = new InsurancePolicyService();
        IPolicyService proxy = new InsurancePolicyServiceProxy(realService);

        _output.Display(proxy.GetPolicyInfo("P123"));
        _output.Display(proxy.GetPolicyInfo("P123"));
        _output.Display(proxy.GetPolicyInfo("P456"));
    }
}
