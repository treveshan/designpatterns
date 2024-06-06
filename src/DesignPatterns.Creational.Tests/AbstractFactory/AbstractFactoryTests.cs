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

namespace DesignPatterns.Creational.Tests.AbstractFactory
{

    [TestFixture]
    public class AbstractFactoryTests
    {
        [TestFixture]
        public class Run
        {
            [Test]
            public void GivenIndividual_ShouldOutputAllIndividualPolicies()
            {
                //Arrange
                var output = Substitute.For<IOutput>();
                var capturedOutput = new List<string>();
                output.Display(Arg.Do<string>(s => capturedOutput.Add(s)));

                var sut = CreateAbstractFactory(output);
                var policyType = "Individual";

                //Act
                sut.Run(policyType);

                //Assert

                var expected = new List<string>
                {
                    "Individual Health Insurance Policy Details",
                    "Individual Car Insurance Policy Details",
                    "Individual Home Insurance Policy Details",
                };
                capturedOutput.Should().BeEquivalentTo(expected);
            }

            [Test]
            public void GivenCorporate_ShouldOutputAllIndividualPolicies()
            {
                //Arrange
                var output = Substitute.For<IOutput>();
                var capturedOutput = new List<string>();
                output.Display(Arg.Do<string>(s => capturedOutput.Add(s)));

                var sut = CreateAbstractFactory(output);
                var policyType = "Corporate";

                //Act
                sut.Run(policyType);

                //Assert

                var expected = new List<string>
                {
                    "Corporate Health Insurance Policy Details",
                    "Corporate Car Insurance Policy Details",
                    "Corporate Home Insurance Policy Details",
                };
                capturedOutput.Should().BeEquivalentTo(expected);
            }

            private Creational.AbstractFactory.AbstractFactory CreateAbstractFactory(IOutput output)
            {
                return new Creational.AbstractFactory.AbstractFactory(output);
            }
        }


    }
}
