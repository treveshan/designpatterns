using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        private IOutput _output;

        public ChainOfResponsibility(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            // Create handlers
            IClaimHandler claimAdminOne = new ClaimAdminOne();
            IClaimHandler claimAdminTwo = new ClaimAdminTwo();
            IClaimHandler paymentAdminOne = new PaymentAdminOne();
            IClaimHandler paymentAdminTwo = new PaymentAdminTwo();
            IClaimHandler claimComplete = new ClaimComplete();

            // Set up the chain: Claim Admin One -> Claim Admin Two -> Payment Admin One -> Payment Admin Two -> Complete
            claimAdminOne
                .SetNext(claimAdminTwo)
                .SetNext(paymentAdminOne)
                .SetNext(paymentAdminTwo)
                .SetNext(claimComplete);

            // Define test claims with different types and amounts
            var claims = new Claim[]
            {
                new Claim("Claim", 800, "Car service"),       // Should be approved by Claim Admin One
                new Claim("Claim", 3000, "Car accident"),           // Should be approved by Claim Admin Two
                new Claim("Payment", 7000, "House repair payment"),       // Should be approved by Payment Admin One
                new Claim("Payment", 15000, "Major accident repair"),     // Should be approved by Payment Admin Two
                new Claim("Claim", 12000, "Large insurance claim"),       // Should not be processed by any handler
                new Claim("Invalid", 5000, "Unsupported claim type")      // Should fail due to unsupported type
            };

            foreach (var claim in claims)
            {
                _output.Display($"\nProcessing {claim}:");
                var result = claimAdminOne.ProcessClaim(claim);
                _output.Display(result.ToString());
            }
        }
    }
}
