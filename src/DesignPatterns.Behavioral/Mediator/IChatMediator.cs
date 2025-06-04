namespace DesignPatterns.Behavioral.Mediator;

public interface IChatMediator
{
    void Send(string from, string message);
    void Register(Participant participant);
}
