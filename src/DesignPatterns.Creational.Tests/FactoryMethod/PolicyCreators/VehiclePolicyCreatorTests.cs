using DesignPatterns.Creational.FactoryMethod.PolicyCreators;
using DesignPatterns.Creational.FactoryMethod.PolicyTypes;
using DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators.Mocks;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.FactoryMethod.PolicyCreators;

[TestFixture]
public class VehiclePolicyCreatorTests
{
    [TestFixture]
    public class CreatePolicy
    {
        [Test]
        public void ShouldCreateVehiclePolicy()
        {
            //Arrange
            var vehiclePolicyCreator = CreateVehiclePolicyCreator();

            //Act
            var policy = vehiclePolicyCreator.CreatePolicy();

            //Assert
            policy.Should().BeOfType<VehiclePolicy>();
        }


        [Test]
        public void ShouldOnlyCreateVehiclePolicy()
        {
            //Arrange
            var vehiclePolicyCreator = CreateVehiclePolicyCreator();

            //Act
            var policy = vehiclePolicyCreator.CreatePolicy();

            //Assert
            policy.Should().NotBeOfType<TestPolicy>();
        }

        private VehiclePolicyCreator CreateVehiclePolicyCreator()
        {
            return new VehiclePolicyCreator();
        }
    }
      
}