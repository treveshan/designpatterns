using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        private readonly IOutput _output;

        public Facade(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            var insuranceFacade = new InsuranceFacade();

            // Use the facade to create a new policy
            var createPolicyResult = insuranceFacade.CreateNewPolicy("P12345", "Health");
            _output.Display(createPolicyResult);

            // Make a claim through the facade
            var claimResult = insuranceFacade.MakeClaim("P12345", 500);
            _output.Display(claimResult);

            // Process a payment through the facade
            var paymentResult = insuranceFacade.MakePayment("P12345", 150);
            _output.Display(paymentResult);

            // Retrieve policy information
            var policyInfoResult = insuranceFacade.GetPolicyInfo("P12345");
            _output.Display(policyInfoResult);
        }
    }
}
