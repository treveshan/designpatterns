using DesignPatterns.Structural.Decorator;
using FluentAssertions;

namespace DesignPatterns.Structural.Tests;

public class DecoratorPatternTests
{
    public class InsurancePolicyTests
    {
        [Test]
        public void ShouldReturnCorrectDetailsForBasicPolicy()
        {
            // Arrange
            IInsurancePolicy healthPolicy = new HealthInsurancePolicy(500);

            // Act
            var details = healthPolicy.GetDetails();
            var premium = healthPolicy.GetPremium();

            // Assert
            details.Should().Be("Health Insurance with premium: 500");
            premium.Should().Be(500);
        }

        [Test]
        public void ShouldAddAccidentCoverageToPolicy()
        {
            // Arrange
            IInsurancePolicy carPolicy = new CarInsurancePolicy(800);
            carPolicy = new AccidentCoverageDecorator(carPolicy, 150);

            // Act
            var details = carPolicy.GetDetails();
            var premium = carPolicy.GetPremium();

            // Assert
            details.Should().Be("Car Insurance with premium: 800 + Accident Coverage");
            premium.Should().Be(950);
        }

        [Test]
        public void ShouldAddMultipleCoveragesToPolicy()
        {
            // Arrange
            IInsurancePolicy homePolicy = new HomeInsurancePolicy(1000);
            homePolicy = new AccidentCoverageDecorator(homePolicy, 200);
            homePolicy = new FireProtectionDecorator(homePolicy, 300);

            // Act
            var details = homePolicy.GetDetails();
            var premium = homePolicy.GetPremium();

            // Assert
            details.Should().Be("Home Insurance with premium: 1000 + Accident Coverage + Fire Protection");
            premium.Should().Be(1500);
        }
    }
}