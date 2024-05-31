namespace DesignPatterns.Utils.Display;

public class ConsoleOutput : IOutput
{
    public void Display(string value)
    {
        Console.WriteLine(value);
    }
}