using DesignPatterns.Behavioral.TemplateMethod;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.TemplateMethod;

public class TemplateMethodPatternTests
{
    [Test]
    public void AutoClaimProcess_ShouldReturnCorrectAmount()
    {
        ClaimProcessTemplate process = new AutoClaimProcess();
        process.Process().Should().Be("Amount: 500");
    }
}
