using DesignPatterns.Behavioral.Interpreter;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Interpreter;

public class InterpreterPatternTests
{
    [Test]
    public void ShouldEvaluateRpnExpression()
    {
        var result = RpnInterpreter.Evaluate("5 1 2 + 4 - +");
        result.Should().Be(4);
    }
}
