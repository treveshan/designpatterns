using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Claim
    {
        public string Type { get; }
        public double Amount { get; }
        public string Description { get; }

        public Claim(string type, double amount, string description)
        {
            Type = type;
            Amount = amount;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Type} Claim - Amount: ${Amount}, Description: {Description}";
        }
    }
}
