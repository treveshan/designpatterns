using DesignPatterns.Structural.Facade;
using FluentAssertions;

namespace DesignPatterns.Structural.Tests
{
    public class InsuranceFacadeTests
    {
        [Test]
        public void CreateNewPolicy_ShouldReturnExpectedString()
        {
            // Arrange
            var facade = new InsuranceFacade();
            string policyId = "P12345";
            string policyType = "Health";

            // Act
            string result = facade.CreateNewPolicy(policyId, policyType);

            // Assert
            result.Should().Be("---- Creating a new policy ----\nCreating policy P12345 of type Health.\nPolicy creation completed.");
        }

        [Test]
        public void MakeClaim_ShouldReturnExpectedString()
        {
            // Arrange
            var facade = new InsuranceFacade();
            string policyId = "P12345";
            double claimAmount = 500;

            // Act
            string result = facade.MakeClaim(policyId, claimAmount);

            // Assert
            result.Should().Be("---- Processing a new claim ----\nProcessing claim for policy P12345 with amount $500.\nClaim processing completed.");
        }

        [Test]
        public void MakePayment_ShouldReturnExpectedString()
        {
            // Arrange
            var facade = new InsuranceFacade();
            string policyId = "P12345";
            double paymentAmount = 150;

            // Act
            string result = facade.MakePayment(policyId, paymentAmount);

            // Assert
            result.Should().Be("---- Processing a payment ----\nProcessing payment for policy P12345 with amount $150.\nPayment processing completed.");
        }

        [Test]
        public void GetPolicyInfo_ShouldReturnExpectedString()
        {
            // Arrange
            var facade = new InsuranceFacade();
            string policyId = "P12345";

            // Act
            string result = facade.GetPolicyInfo(policyId);

            // Assert
            result.Should().Be("---- Retrieving policy information ----\nRetrieving details for policy P12345.\nChecking payment status for policy P12345.\nPolicy information retrieval completed.");
        }
    }
}
