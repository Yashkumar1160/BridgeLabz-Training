using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    public class Service
    {
        //Protected Fields
        protected string serviceName;
        protected double serviceCost;

        //static variable 
        public static string CityName = "TechVille";

        //Constructor
        public Service(string name, double cost)
        {
            serviceName = name;
            serviceCost = cost;
        }

        //method to display service details
        public virtual void DisplayServiceDetails()
        {
            Console.WriteLine($"Service: {serviceName}");
            Console.WriteLine($"Cost: {serviceCost}");
            Console.WriteLine($"City: {CityName}");
        }
    }
}