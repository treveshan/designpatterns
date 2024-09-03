using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class HomeInsurancePolicy : IInsurancePolicy
    {
        private readonly IInsuranceProvider _provider;

        public HomeInsurancePolicy(IInsuranceProvider provider)
        {
            _provider = provider;
        }

        public string GetPolicyDetails()
        {
            return "Home Insurance Policy Details";
        }

        public string IssuePolicy()
        {
            return _provider.IssuePolicy("Home");
        }
    }

}
