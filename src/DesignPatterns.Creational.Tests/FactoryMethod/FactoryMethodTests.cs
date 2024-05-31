using DesignPatterns.Creational.FactoryMethod.PolicyTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Utils.Display;
using FluentAssertions;
using NSubstitute;
using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Creational.Tests.FactoryMethod
{

    [TestFixture]
    public class FactoryMethodTests
    {
        [TestFixture]
        public class Run
        {
            [Test]
            public void GivenHealth_ShouldOutputHealthInsurance()
            {
                //Arrange
                var output = Substitute.For<IOutput>();
                var capturedOutput = "";
                output.Display(Arg.Do<string>(s => capturedOutput = s));

                var sut = CreateFactoryMethod(output);
                var policyType = "Health";

                //Act
                sut.Run(policyType);

                //Assert
                capturedOutput.Should().Be("Created policy type: Health Insurance");
            }

            [Test]
            public void GivenLife_ShouldOutputLifeInsurance()
            {
                //Arrange
                var output = Substitute.For<IOutput>();
                var capturedOutput = "";
                output.Display(Arg.Do<string>(s => capturedOutput = s));

                var sut = CreateFactoryMethod(output);
                var policyType = "Life";

                //Act
                sut.Run(policyType);

                //Assert
                capturedOutput.Should().Be("Created policy type: Life Insurance");
            }

            [Test]
            public void GivenVehicle_ShouldOutputVehicleInsurance()
            {
                //Arrange
                var output = Substitute.For<IOutput>();
                var capturedOutput = "";
                output.Display(Arg.Do<string>(s => capturedOutput = s));

                var sut = CreateFactoryMethod(output);
                var policyType = "Vehicle";

                //Act
                sut.Run(policyType);

                //Assert
                capturedOutput.Should().Be("Created policy type: Vehicle Insurance");
            }

            [Test]
            public void GivenInvalidType_ShouldOutputInvalidPolicyType()
            {
                //Arrange
                var output = Substitute.For<IOutput>();
                var capturedOutput = "";
                output.Display(Arg.Do<string>(s => capturedOutput = s));

                var sut = CreateFactoryMethod(output);
                var policyType = "Broken";

                //Act
                sut.Run(policyType);

                //Assert
                capturedOutput.Should().Be("Invalid policy type.");
            }

            private Creational.FactoryMethod.FactoryMethod CreateFactoryMethod(IOutput output)
            {
                return new Creational.FactoryMethod.FactoryMethod(output);
            }
        }


    }
}
