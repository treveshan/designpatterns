using DesignPatterns.Behavioral.Observer;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Observer;

public class ObserverPatternTests
{
    [Test]
    public void Observers_ShouldReceiveUpdates()
    {
        var subject = new PolicySubject();
        var dep = new DepartmentObserver();
        subject.Attach(dep);

        subject.Notify("X");

        dep.Notifications.Should().ContainSingle().Which.Should().Be("Policy X updated");
    }
}
