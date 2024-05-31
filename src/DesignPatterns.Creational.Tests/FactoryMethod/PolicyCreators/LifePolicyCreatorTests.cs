using DesignPatterns.Creational.FactoryMethod.PolicyCreators;
using DesignPatterns.Creational.FactoryMethod.PolicyTypes;
using DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators.Mocks;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators
{
    [TestFixture]
    public class LifePolicyCreatorTests
    {
        [TestFixture]
        public class CreatePolicy
        {
            [Test]
            public void ShouldCreateLifePolicy()
            {
                //Arrange
                var lifePolicyCreator = CreateLifePolicyCreator();

                //Act
                var policy = lifePolicyCreator.CreatePolicy();

                //Assert
                policy.Should().BeOfType<LifePolicy>();
            }


            [Test]
            public void ShouldOnlyCreateLifePolicy()
            {
                //Arrange
                var lifePolicyCreator = CreateLifePolicyCreator();

                //Act
                var policy = lifePolicyCreator.CreatePolicy();

                //Assert
                policy.Should().NotBeOfType<TestPolicy>();
            }
            
            private LifePolicyCreator CreateLifePolicyCreator()
            {
                return new LifePolicyCreator();
            }
        }
      
    }
}