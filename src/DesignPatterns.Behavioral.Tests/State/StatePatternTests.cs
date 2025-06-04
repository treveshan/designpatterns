using DesignPatterns.Behavioral.State;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.State;

public class StatePatternTests
{
    [Test]
    public void ShouldTransitionThroughStates()
    {
        var context = new ClaimContext();
        context.State.Status.Should().Be("Submitted");
        context.Next();
        context.State.Status.Should().Be("Approved");
        context.Next();
        context.State.Status.Should().Be("Closed");
    }
}
