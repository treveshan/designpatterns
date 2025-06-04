using DesignPatterns.Behavioral.Mediator;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Mediator;

public class MediatorPatternTests
{
    [Test]
    public void Participants_ShouldReceiveMessages()
    {
        var mediator = new ChatMediator();
        var alice = new Participant("Alice");
        var bob = new Participant("Bob");
        mediator.Register(alice);
        mediator.Register(bob);

        alice.Send("Hi Bob");
        bob.Send("Hello Alice");

        alice.Received.Should().ContainSingle().Which.Should().Be("Bob: Hello Alice");
        bob.Received.Should().ContainSingle().Which.Should().Be("Alice: Hi Bob");
    }
}
