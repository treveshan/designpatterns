using DesignPatterns.Behavioral.Command;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Command;

public class CommandPatternTests
{
    [Test]
    public void Invoker_ShouldExecuteAddAndRemove()
    {
        var service = new PolicyService();
        var invoker = new Invoker();
        var add = new AddPolicyCommand(service, "P1");
        var remove = new RemovePolicyCommand(service, "P1");

        var addResult = invoker.ExecuteCommand(add);
        var removeResult = invoker.ExecuteCommand(remove);

        addResult.Should().Be("Policy P1 added");
        removeResult.Should().Be("Policy P1 removed");
        service.Policies.Should().BeEmpty();
    }
}
