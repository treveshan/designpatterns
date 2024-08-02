using DesignPatterns.Structural.Adapter;

namespace DesignPatterns.Structural.Tests
{
    public class InsurancePolicyAdapterTests
    {
        [Test]
        public void ShouldAdaptLegacyPolicyDetailsCorrectly()
        {
            // Arrange
            var legacySystem = new LegacyInsuranceSystem();
            var adapter = new InsurancePolicyAdapter(legacySystem);

            // Act
            var policyDetails = adapter.GetPolicyDetails();

            // Assert
            policyDetails.Should().Be("Type=Comprehensive, Premium=1500, CoverAmount=500000, Benefits=Benefit1;Benefit2");
        }

        [Test]
        public void ShouldCalculatePremiumCorrectlyUsingAdapter()
        {
            // Arrange
            var legacySystem = new LegacyInsuranceSystem();
            var adapter = new InsurancePolicyAdapter(legacySystem);

            // Act
            var premium = adapter.CalculatePremium(1000, 23, true);

            // Assert
            premium.Should().Be(2000);
        }
    }
}