using DesignPatterns.Behavioral.Memento;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Memento;

public class MementoPatternTests
{
    [Test]
    public void ShouldRestoreState()
    {
        var policy = new InsurancePolicy(100);
        var memento = policy.Save();
        policy = new InsurancePolicy(300);
        policy.Restore(memento);

        policy.Coverage.Should().Be(100);
    }
}
