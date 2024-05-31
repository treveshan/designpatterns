using DesignPatterns.Creational.FactoryMethod.PolicyCreators;
using DesignPatterns.Creational.FactoryMethod.PolicyTypes;
using DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators.Mocks;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators;

[TestFixture]
public class HealthPolicyCreatorTests
{
    [TestFixture]
    public class CreatePolicy
    {
        [Test]
        public void ShouldCreateHealthPolicy()
        {
            //Arrange
            var healthPolicyCreator = CreateHealthPolicyCreator();

            //Act
            var policy = healthPolicyCreator.CreatePolicy();

            //Assert
            policy.Should().BeOfType<HealthPolicy>();
        }


        [Test]
        public void ShouldOnlyCreateHealthPolicy()
        {
            //Arrange
            var healthPolicyCreator = CreateHealthPolicyCreator();

            //Act
            var policy = healthPolicyCreator.CreatePolicy();

            //Assert
            policy.Should().NotBeOfType<TestPolicy>();
        }

        private HealthPolicyCreator CreateHealthPolicyCreator()
        {
            return new HealthPolicyCreator();
        }
    }
      
}