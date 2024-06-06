using DesignPatterns.Creational.Prototype;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.Prototype
{
    public class InsurancePolicyPrototypeTests
    {
        [Test]
        public void ShouldClonePolicyCorrectly()
        {
            // Arrange
            var originalPolicy = new InsurancePolicy
            {
                PolicyType = "Comprehensive",
                Premium = 1500.00,
                CoverAmount = 500000.00
            };

            // Act
            var clonedPolicy = originalPolicy.Clone() as InsurancePolicy;

            // Assert
            clonedPolicy.Should().NotBeNull();
            clonedPolicy.Should().NotBeSameAs(originalPolicy);
            clonedPolicy.PolicyType.Should().Be(originalPolicy.PolicyType);
            clonedPolicy.Premium.Should().Be(originalPolicy.Premium);
            clonedPolicy.CoverAmount.Should().Be(originalPolicy.CoverAmount);

            // Modify the cloned policy to ensure deep clone
            clonedPolicy.PolicyType = "Basic";
            clonedPolicy.Premium = 500.00;
            clonedPolicy.CoverAmount = 100000.00;

            // Ensure original policy is unchanged
            originalPolicy.PolicyType.Should().Be("Comprehensive");
            originalPolicy.Premium.Should().Be(1500.00);
            originalPolicy.CoverAmount.Should().Be(500000.00);
        }
    }
}
