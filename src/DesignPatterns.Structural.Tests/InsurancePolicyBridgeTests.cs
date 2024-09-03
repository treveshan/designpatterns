using DesignPatterns.Structural.Bridge;
using FluentAssertions;
using NSubstitute;

namespace DesignPatterns.Structural.Tests;

public class InsurancePolicyTests
{
    [Test]
    public void ShouldIssueHealthPolicyWithProviderA()
    {
        // Arrange
        var mockProvider = Substitute.For<IInsuranceProvider>();
        mockProvider.IssuePolicy(Arg.Any<string>())
            .Returns(args => $"Provider A: Issuing {args[0]} policy.");
        var healthInsurance = new HealthInsurancePolicy(mockProvider);

        // Act
        var result = healthInsurance.IssuePolicy();

        // Assert
        result.Should().Be("Provider A: Issuing Health policy.");
        mockProvider.Received(1).IssuePolicy("Health");
    }

    [Test]
    public void ShouldIssueCarPolicyWithProviderB()
    {
        // Arrange
        var mockProvider = Substitute.For<IInsuranceProvider>();
        mockProvider.IssuePolicy(Arg.Any<string>())
            .Returns(args => $"Provider B: Issuing {args[0]} policy.");
        var carInsurance = new CarInsurancePolicy(mockProvider);

        // Act
        var result = carInsurance.IssuePolicy();

        // Assert
        result.Should().Be("Provider B: Issuing Car policy.");
        mockProvider.Received(1).IssuePolicy("Car");
    }

    [Test]
    public void ShouldIssueHomePolicyWithProviderA()
    {
        // Arrange
        var mockProvider = Substitute.For<IInsuranceProvider>();
        mockProvider.IssuePolicy(Arg.Any<string>())
            .Returns(args => $"Provider A: Issuing {args[0]} policy.");
        var homeInsurance = new HomeInsurancePolicy(mockProvider);

        // Act
        var result = homeInsurance.IssuePolicy();

        // Assert
        result.Should().Be("Provider A: Issuing Home policy.");
        mockProvider.Received(1).IssuePolicy("Home");
    }
}