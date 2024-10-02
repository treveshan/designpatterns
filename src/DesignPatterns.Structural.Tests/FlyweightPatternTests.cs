using DesignPatterns.Structural.Flyweight;
using FluentAssertions;

namespace DesignPatterns.Structural.Tests;

public class FlyweightPatternTests
{
    public class InsuranceTypeFactoryTests
    {
        [Test]
        public void ShouldReuseInsuranceTypeForSamePolicyType()
        {
            // Arrange
            var factory = new InsuranceTypeFactory();

            // Act
            var type1 = factory.GetInsuranceType("Health", "Full Coverage");
            var type2 = factory.GetInsuranceType("Health", "Full Coverage");

            // Assert
            type1.Should().BeSameAs(type2, "Factory should return the same instance for the same insurance type");
        }

        [Test]
        public void ShouldCreateDifferentInsuranceTypesForDifferentPolicyTypes()
        {
            // Arrange
            var factory = new InsuranceTypeFactory();

            // Act
            var healthType = factory.GetInsuranceType("Health", "Full Coverage");
            var carType = factory.GetInsuranceType("Car", "Collision Coverage");

            // Assert
            healthType.Should().NotBeSameAs(carType, "Factory should return different instances for different insurance types");
        }
    }

    public class InsurancePolicyTests
    {
        [Test]
        public void ShouldStoreCustomerSpecificPolicyDetails()
        {
            // Arrange
            var factory = new InsuranceTypeFactory();
            var healthType = factory.GetInsuranceType("Health", "Full Coverage");

            var policy1 = new InsurancePolicy(healthType, "Mdu Doe", "P123456");
            var policy2 = new InsurancePolicy(healthType, "Trev Doe", "P123457");

            // Act
            var details1 = policy1.GetPolicyDetails();
            var details2 = policy2.GetPolicyDetails();

            // Assert
            details1.Should().Be("Policy No: P123456, Customer: Mdu Doe, Type: Health, Coverage: Full Coverage");
            details2.Should().Be("Policy No: P123457, Customer: Trev Doe, Type: Health, Coverage: Full Coverage");
        }
    }

}