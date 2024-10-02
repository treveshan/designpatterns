using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Composite
{
    public class Composite
    {
        private readonly IOutput _output;

        public Composite(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            // Create individual insurance policies (leaves)
            IInsuranceComponent healthPolicy = new HealthInsurancePolicy(500);
            IInsuranceComponent carPolicy = new CarInsurancePolicy(800);
            IInsuranceComponent homePolicy = new HomeInsurancePolicy(1000);

            // Create an insurance package (composite)
            var insurancePackage = new InsurancePackage();
            insurancePackage.AddComponent(healthPolicy);
            insurancePackage.AddComponent(carPolicy);
            insurancePackage.AddComponent(homePolicy);

            // Create another package (nested composite)
            var additionalPackage = new InsurancePackage();
            additionalPackage.AddComponent(new HealthInsurancePolicy(300));
            additionalPackage.AddComponent(new CarInsurancePolicy(400));

            insurancePackage.AddComponent(additionalPackage);

            // Display details and total premium of the package
            _output.Display(insurancePackage.GetDetails());
            _output.Display($"Total Premium: {insurancePackage.GetPremium()}");
        }
    }
}
