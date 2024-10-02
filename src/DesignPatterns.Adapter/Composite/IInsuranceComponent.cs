using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public interface IInsuranceComponent
    {
        string GetDetails();
        double GetPremium();
    }
}
