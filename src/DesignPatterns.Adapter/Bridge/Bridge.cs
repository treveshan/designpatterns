using DesignPatterns.Structural.Adapter;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Bridge
{
    public class Bridge 
    {
        private readonly IOutput _output;

        public Bridge(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            // Create provider implementations
            IInsuranceProvider providerA = new ProviderA();
            IInsuranceProvider providerB = new ProviderB();

            // Create insurance policies with different providers
            IInsurancePolicy healthInsurance = new HealthInsurancePolicy(providerA);
            IInsurancePolicy carInsurance = new CarInsurancePolicy(providerB);
            IInsurancePolicy homeInsurance = new HomeInsurancePolicy(providerA);

            // Issue policies
            var healthPolicyResult = healthInsurance.IssuePolicy();
            var carPolicyResult = carInsurance.IssuePolicy();
            var homePolicyResult = homeInsurance.IssuePolicy();

            // Print results
            _output.Display(healthPolicyResult);
            _output.Display(carPolicyResult);
            _output.Display(homePolicyResult);
        }
    }
}
