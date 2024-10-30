using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.ChainOfResponsibility
{
    public class ChainOfResponsibilityTests
    {
        [Test]
        public void ClaimAdminOne_ShouldApproveSmallClaim()
        {
            // Arrange
            var claimAdminOne = new ClaimAdminOne();
            var claim = new Claim("Claim", 800, "Routine medical expense");

            // Act
            var result = claimAdminOne.ProcessClaim(claim);

            // Assert
            result.IsProcessed.Should().BeTrue();
            result.Message.Should().Be("Claim Admin One approved the Claim Claim - Amount: $800, Description: Routine medical expense");
        }

        [Test]
        public void ClaimAdminTwo_ShouldApproveMediumClaim()
        {
            // Arrange
            var claimAdminOne = new ClaimAdminOne();
            var claimAdminTwo = new ClaimAdminTwo();
            claimAdminOne.SetNext(claimAdminTwo);

            var claim = new Claim("Claim", 3000, "Minor car accident");

            // Act
            var result = claimAdminOne.ProcessClaim(claim);

            // Assert
            result.IsProcessed.Should().BeTrue();
            result.Message.Should().Be("Claim Admin Two approved the Claim Claim - Amount: $3000, Description: Minor car accident");
        }

        [Test]
        public void PaymentAdminOne_ShouldApprovePaymentUpTo10000()
        {
            // Arrange
            var claimAdminOne = new ClaimAdminOne();
            var claimAdminTwo = new ClaimAdminTwo();
            var paymentAdminOne = new PaymentAdminOne();
            claimAdminOne.SetNext(claimAdminTwo).SetNext(paymentAdminOne);

            var payment = new Claim("Payment", 7000, "House repair payment");

            // Act
            var result = claimAdminOne.ProcessClaim(payment);

            // Assert
            result.IsProcessed.Should().BeTrue();
            result.Message.Should().Be("Payment Admin One approved the Payment Claim - Amount: $7000, Description: House repair payment");
        }

        [Test]
        public void PaymentAdminTwo_ShouldApprovePayment()
        {
            // Arrange
            var claimAdminOne = new ClaimAdminOne();
            var claimAdminTwo = new ClaimAdminTwo();
            var paymentAdminOne = new PaymentAdminOne();
            var paymentAdminTwo = new PaymentAdminTwo();
            claimAdminOne.SetNext(claimAdminTwo).SetNext(paymentAdminOne).SetNext(paymentAdminTwo);

            var payment = new Claim("Payment", 11999, "High-value transaction");

            // Act
            var result = claimAdminOne.ProcessClaim(payment);

            // Assert
            result.IsProcessed.Should().BeTrue();
            result.Message.Should().Be("Payment Admin Two approved the Payment Claim - Amount: $11999, Description: High-value transaction");
        }

        [Test]
        public void Chain_ShouldReturnFailure_WhenClaimAmountIsTooHigh()
        {
            // Arrange
            var claimAdminOne = new ClaimAdminOne();
            var claimAdminTwo = new ClaimAdminTwo();
            var paymentAdminOne = new PaymentAdminOne();
            var paymentAdminTwo = new PaymentAdminTwo();
            claimAdminOne.SetNext(claimAdminTwo).SetNext(paymentAdminOne).SetNext(paymentAdminTwo);

            var claim = new Claim("Payment", 12000, "Large insurance claim");

            // Act
            var result = claimAdminOne.ProcessClaim(claim);

            // Assert
            result.IsProcessed.Should().BeFalse();
            result.Message.Should().Be("Claim Admin Two could not process the claim and there are no further handlers.");
        }

        [Test]
        public void Chain_ShouldReturnFailure_WhenUnsupportedClaimType()
        {
            // Arrange
            var claimAdminOne = new ClaimAdminOne();
            var claimAdminTwo = new ClaimAdminTwo();
            var paymentAdminOne = new PaymentAdminOne();
            var paymentAdminTwo = new PaymentAdminTwo();
            claimAdminOne.SetNext(claimAdminTwo).SetNext(paymentAdminOne).SetNext(paymentAdminTwo);

            var invalidClaim = new Claim("Invalid", 5000, "Unsupported claim type");

            // Act
            var result = claimAdminOne.ProcessClaim(invalidClaim);

            // Assert
            result.IsProcessed.Should().BeFalse();
            result.Message.Should().Be("Request type not handled by Payment Admin Two.");
        }
    }
}
