using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.Builder;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.Builder
{
    public class InsurancePolicyBuilderTests
    {
        [Test]
        public void ShouldBuildComprehensivePolicyCorrectly()
        {
            // Arrange
            var builder = new InsurancePolicyBuilder();
            var director = new InsurancePolicyDirector();

            // Act
            InsurancePolicy policy = director.ConstructComprehensivePolicy(builder);

            // Assert
            policy.PolicyType.Should().Be("Comprehensive");
            policy.Premium.Should().Be(1500.00);
            policy.CoverAmount.Should().Be(500000.00);
        }

        [Test]
        public void ShouldBuildBasicPolicyCorrectly()
        {
            // Arrange
            var builder = new InsurancePolicyBuilder();
            var director = new InsurancePolicyDirector();

            // Act
            InsurancePolicy policy = director.ConstructBasicPolicy(builder);

            // Assert
            policy.PolicyType.Should().Be("Basic");
            policy.Premium.Should().Be(500.00);
            policy.CoverAmount.Should().Be(100000.00);
        }

        [Test]
        public void ShouldBuildCustomPolicyCorrectlyUsingFluentSyntax()
        {
            // Arrange
            var builder = new InsurancePolicyBuilder();

            // Act
            InsurancePolicy policy = builder
                .WithPolicyType("Custom")
                .WithPremium(1200.00)
                .WithCoverAmount(300000.00)
                .Build();

            // Assert
            policy.PolicyType.Should().Be("Custom");
            policy.Premium.Should().Be(1200.00);
            policy.CoverAmount.Should().Be(300000.00);
        }
    }
}
