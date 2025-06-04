namespace DesignPatterns.Behavioral.Mediator;

public class ChatMediator : IChatMediator
{
    private readonly List<Participant> _participants = new();

    public void Send(string from, string message)
    {
        foreach (var p in _participants.Where(p => p.Name != from))
        {
            p.Receive(from, message);
        }
    }

    public void Register(Participant participant)
    {
        _participants.Add(participant);
        participant.Mediator = this;
    }
}
