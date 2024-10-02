using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Decorator
{
    public class Decorator
    {
        private readonly IOutput _output;

        public Decorator(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            // Create a basic health insurance policy
            IInsurancePolicy healthPolicy = new HealthInsurancePolicy(500);

            // Decorate the health policy with accident coverage
            healthPolicy = new AccidentCoverageDecorator(healthPolicy, 100);

            // Further decorate the policy with fire protection
            healthPolicy = new FireProtectionDecorator(healthPolicy, 50);

            // Print the final details and premium
            _output.Display(healthPolicy.GetDetails());
            _output.Display($"Total Premium: {healthPolicy.GetPremium()}");
        }
    }
}
