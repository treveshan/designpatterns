using DesignPatterns.Structural.Composite;
using FluentAssertions;

namespace DesignPatterns.Structural.Tests;

public class CompositePatternTests
{
    public class InsurancePolicyTests
    {
        [Test]
        public void ShouldCalculatePremiumForSinglePolicy()
        {
            // Arrange
            IInsuranceComponent healthPolicy = new HealthInsurancePolicy(500);

            // Act
            var premium = healthPolicy.GetPremium();

            // Assert
            premium.Should().Be(500);
        }

        [Test]
        public void ShouldCalculateTotalPremiumForPackage()
        {
            // Arrange
            var insurancePackage = new InsurancePackage();
            insurancePackage.AddComponent(new HealthInsurancePolicy(500));
            insurancePackage.AddComponent(new CarInsurancePolicy(800));

            // Act
            var totalPremium = insurancePackage.GetPremium();

            // Assert
            totalPremium.Should().Be(1300);
        }

        [Test]
        public void ShouldCalculateTotalPremiumForNestedPackages()
        {
            // Arrange
            var mainPackage = new InsurancePackage();
            mainPackage.AddComponent(new HealthInsurancePolicy(500));
            mainPackage.AddComponent(new CarInsurancePolicy(800));

            var subPackage = new InsurancePackage();
            subPackage.AddComponent(new HealthInsurancePolicy(300));
            subPackage.AddComponent(new CarInsurancePolicy(400));

            mainPackage.AddComponent(subPackage);

            // Act
            var totalPremium = mainPackage.GetPremium();

            // Assert
            totalPremium.Should().Be(2000);
        }

        [Test]
        public void ShouldReturnCorrectDetailsForPackage()
        {
            // Arrange
            var insurancePackage = new InsurancePackage();
            insurancePackage.AddComponent(new HealthInsurancePolicy(500));
            insurancePackage.AddComponent(new CarInsurancePolicy(800));

            // Act
            var details = insurancePackage.GetDetails();

            // Assert
            details.Should().Contain("Health Insurance with premium: 500");
            details.Should().Contain("Car Insurance with premium: 800");
        }
    }
}