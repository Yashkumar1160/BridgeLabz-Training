using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    //M-6 City Services Framework
    public class Service
    {
        //Protected Fields
        protected string serviceName;
        protected double serviceCost;

        //static variable 
        public static string CityName = "TechVille";

        //M-7 Advanced Service Architecture
        public static int TotalServices = 0;

        //M-7 Advanced Service Architecture
        //instance variable
        private int usageCount;

        //Constructor
        public Service(string name, double cost)
        {
            serviceName = name;
            serviceCost = cost;
            //M-7 Advanced Service Architecture
            usageCount = 0;
            TotalServices++;
        }

        //M-7 Method to use Service
        public void UseService()
        {
            usageCount++;
            Console.WriteLine(serviceName + " used " + usageCount + " times");
        }

        //method to display service details
        public virtual void DisplayServiceDetails()
        {
            Console.WriteLine($"Service: {serviceName}");
            Console.WriteLine($"Cost: {serviceCost}");
            Console.WriteLine($"City: {CityName}");
        }

        //method to display total services
        public static void ShowTotalServices()
        {
            Console.WriteLine("Total Services Created: " + TotalServices);
        }

    }
}