using DesignPatterns.Creational.Prototype;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.Prototype
{
    public class InsurancePolicyPrototypeTests
    {
        [Test]
        public void ShouldDeepClonePolicyCorrectly()
        {
            // Arrange
            var originalPolicy = new InsurancePolicy
            {
                PolicyType = "Comprehensive",
                Premium = 1500.00,
                CoverAmount = 500000.00,
                Benefits = new List<string> { "Benefit1", "Benefit2" }
            };

            // Act
            var clonedPolicy = originalPolicy.Clone() as InsurancePolicy;

            // Assert
            clonedPolicy.Should().NotBeNull();
            clonedPolicy.Should().NotBeSameAs(originalPolicy);
            clonedPolicy.PolicyType.Should().Be(originalPolicy.PolicyType);
            clonedPolicy.Premium.Should().Be(originalPolicy.Premium);
            clonedPolicy.CoverAmount.Should().Be(originalPolicy.CoverAmount);
            clonedPolicy.Benefits.Should().NotBeSameAs(originalPolicy.Benefits);
            clonedPolicy.Benefits.Should().BeEquivalentTo(originalPolicy.Benefits);

            // Modify the cloned policy to ensure deep clone
            clonedPolicy.PolicyType = "Basic";
            clonedPolicy.Premium = 500.00;
            clonedPolicy.CoverAmount = 100000.00;
            clonedPolicy.Benefits.Add("Benefit3");

            // Ensure original policy is unchanged
            originalPolicy.PolicyType.Should().Be("Comprehensive");
            originalPolicy.Premium.Should().Be(1500.00);
            originalPolicy.CoverAmount.Should().Be(500000.00);
            originalPolicy.Benefits.Should().BeEquivalentTo(new List<string> { "Benefit1", "Benefit2" });
        }

        [Test]
        public void ShouldCloneMultipleTimesCorrectly()
        {
            // Arrange
            var originalPolicy = new InsurancePolicy
            {
                PolicyType = "Comprehensive",
                Premium = 1500.00,
                CoverAmount = 500000.00,
                Benefits = new List<string> { "Benefit1", "Benefit2" }
            };

            // Act
            var clonedPolicy1 = originalPolicy.Clone() as InsurancePolicy;
            var clonedPolicy2 = originalPolicy.Clone() as InsurancePolicy;

            // Assert
            clonedPolicy1.Should().NotBeSameAs(originalPolicy);
            clonedPolicy2.Should().NotBeSameAs(originalPolicy);
            clonedPolicy1.Should().NotBeSameAs(clonedPolicy2);

            // Verify both clones have the same state as the original
            clonedPolicy1.Should().BeEquivalentTo(clonedPolicy2, options => options.Excluding(p => p.Benefits));
            clonedPolicy1.Benefits.Should().BeEquivalentTo(clonedPolicy2.Benefits);

            // Modify the first cloned policy
            clonedPolicy1.PolicyType = "Basic";
            clonedPolicy1.Premium = 500.00;
            clonedPolicy1.CoverAmount = 100000.00;
            clonedPolicy1.Benefits.Add("Benefit3");

            // Ensure the second clone and original policy are unchanged
            clonedPolicy2.PolicyType.Should().Be("Comprehensive");
            clonedPolicy2.Premium.Should().Be(1500.00);
            clonedPolicy2.CoverAmount.Should().Be(500000.00);
            clonedPolicy2.Benefits.Should().BeEquivalentTo(new List<string> { "Benefit1", "Benefit2" });

            originalPolicy.PolicyType.Should().Be("Comprehensive");
            originalPolicy.Premium.Should().Be(1500.00);
            originalPolicy.CoverAmount.Should().Be(500000.00);
            originalPolicy.Benefits.Should().BeEquivalentTo(new List<string> { "Benefit1", "Benefit2" });
        }

        [Test]
        public void ShouldCloneCorrectlyAcrossMultipleThreads()
        {
            // Arrange
            var originalPolicy = new InsurancePolicy
            {
                PolicyType = "Comprehensive",
                Premium = 1500.00,
                CoverAmount = 500000.00,
                Benefits = new List<string> { "Benefit1", "Benefit2" }
            };

            var clonedPolicies = new InsurancePolicy[10];
            var tasks = new Task[10];

            // Act
            for (int i = 0; i < 10; i++)
            {
                int index = i;
                tasks[i] = Task.Run(() =>
                {
                    clonedPolicies[index] = originalPolicy.Clone() as InsurancePolicy;
                });
            }

            Task.WaitAll(tasks);

            // Assert
            for (int i = 0; i < clonedPolicies.Length; i++)
            {
                clonedPolicies[i].Should().NotBeSameAs(originalPolicy);
                clonedPolicies[i].PolicyType.Should().Be(originalPolicy.PolicyType);
                clonedPolicies[i].Premium.Should().Be(originalPolicy.Premium);
                clonedPolicies[i].CoverAmount.Should().Be(originalPolicy.CoverAmount);
                clonedPolicies[i].Benefits.Should().NotBeSameAs(originalPolicy.Benefits);
                clonedPolicies[i].Benefits.Should().BeEquivalentTo(originalPolicy.Benefits);
            }
        }
    }
}
