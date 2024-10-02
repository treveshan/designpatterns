using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private readonly IOutput _output;

        public Singleton(IOutput output)
        {
            _output = output;
        }

        public void Run(string policyType)
        {
            // Access the singleton instance
            InsurancePolicySingleton policy1 = InsurancePolicySingleton.Instance;
            policy1.PolicyType = "Comprehensive";
            policy1.Premium = 1500.00;
            policy1.CoverAmount = 500000.00;

            // Access the singleton instance again
            InsurancePolicySingleton policy2 = InsurancePolicySingleton.Instance;

            // Display the policy details
            _output.Display("policy 1:" + policy1.ToString());
            _output.Display("policy 2:" + policy2.ToString());

            // Verify both references point to the same instance
            _output.Display("Are the same :" + object.ReferenceEquals(policy1, policy2).ToString()); // Should print 'True'

        }
    }
}
