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
        var light = new Light();
        var remote = new RemoteControl();

        remote.SetCommand(new TurnOnCommand(light));
        remote.PressButton();
        _output.Display($"Light on: {light.IsOn}");

        remote.SetCommand(new TurnOffCommand(light));
        remote.PressButton();
        _output.Display($"Light on: {light.IsOn}");
    }
}
