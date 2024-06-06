using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class InsurancePolicySingleton
    {
        private static InsurancePolicySingleton _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private InsurancePolicySingleton() { }

        public static InsurancePolicySingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new InsurancePolicySingleton();
                    }
                    return _instance;
                }
            }
        }

        // Example property
        public string PolicyType { get; set; }
        public double Premium { get; set; }
        public double CoverAmount { get; set; }

        public override string ToString()
        {
            return $"Policy Type: {PolicyType}, Premium: {Premium}, Cover Amount: {CoverAmount}";
        }
    }

}
