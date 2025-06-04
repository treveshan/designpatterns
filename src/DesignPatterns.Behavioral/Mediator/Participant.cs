namespace DesignPatterns.Behavioral.Mediator;

public class Participant
{
    public string Name { get; }
    public IChatMediator? Mediator { get; set; }
    public List<string> Received { get; } = new();

    public Participant(string name)
    {
        Name = name;
    }

    public void Send(string message)
    {
        Mediator?.Send(Name, message);
    }

    public void Receive(string from, string message)
    {
        Received.Add($"{from}: {message}");
    }
}
