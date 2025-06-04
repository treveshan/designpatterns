using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Command;

public class Command
{
    private readonly IOutput _output;

    public Command(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var service = new PolicyService();
        var invoker = new Invoker();
        var add = new AddPolicyCommand(service, "A");
        var remove = new RemovePolicyCommand(service, "A");

        _output.Display(invoker.ExecuteCommand(add));
        _output.Display(invoker.ExecuteCommand(remove));
    }
}
