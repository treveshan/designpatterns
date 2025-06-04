namespace DesignPatterns.Behavioral.Command;

public class Invoker
{
    public string ExecuteCommand(ICommand command)
    {
        return command.Execute();
    }
}
