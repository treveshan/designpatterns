using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Flyweight
{
    public class Flyweight
    {
        private readonly IOutput _output;

        public Flyweight(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            var factory = new InsuranceTypeFactory();

            // Shared insurance types
            var healthType = factory.GetInsuranceType("Health", "Full Coverage");
            var carType = factory.GetInsuranceType("Car", "Collision Coverage");

            // Policies that share insurance types
            var policy1 = new InsurancePolicy(healthType, "Mdu Doe", "P123456");
            var policy2 = new InsurancePolicy(healthType, "Trev Doe", "P123457");
            var policy3 = new InsurancePolicy(carType, "Dane", "P123458");
            var policy4 = new InsurancePolicy(carType, "Menzi", "P123459");

            // Display policy details
            _output.Display(policy1.GetPolicyDetails());
            _output.Display(policy2.GetPolicyDetails());
            _output.Display(policy3.GetPolicyDetails());
            _output.Display(policy4.GetPolicyDetails());
        }
    }
}
