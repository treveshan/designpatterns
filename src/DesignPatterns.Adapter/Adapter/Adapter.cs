using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Structural.Adapter
{
    public class Adapter
    {
        private readonly IOutput _output;

        public Adapter(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            // Legacy system
            var legacySystem = new LegacyInsuranceSystem();

            // Adapter
            IInsurancePolicy adaptedPolicy = new InsurancePolicyAdapter(legacySystem);

            // Client code using the adapter
            _output.Display(adaptedPolicy.GetPolicyDetails());
            _output.Display("Calculated Premium: " + adaptedPolicy.CalculatePremium(1000, 23, true));
        }
    }
}
