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

        //M-8 City Service Hierarchy
        protected string status;

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
            //M-8 City Service Hierarchy
            status = "Not Registered";
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


        //method to Register
        public virtual void Register()
        {
            status = "Registered";
            Console.WriteLine(serviceName + " registered successfully.");
        }

        //method to Cancel
        public virtual void Cancel()
        {
            status = "Cancelled";
            Console.WriteLine(serviceName + " cancelled.");
        }

        //method to Check Status
        public void CheckStatus()
        {
            Console.WriteLine("Current Status: " + status);
        }

        //method to book service
        public void BookService(string citizenName)
        {
            Console.WriteLine(serviceName + " booked by " + citizenName);
        }

        //M-8 Method overloading
        public void BookService(string citizenName, int priority)
        {
            Console.WriteLine(serviceName + " booked by " + citizenName +
                              " with priority " + priority);
        }


        //M-8 Method overriding
        public override string ToString()
        {
            return $"Service: {serviceName}, Cost: {serviceCost}, Status: {status}";
        }

        //override Equals method
        public override bool Equals(object obj)
        {
            Service other = obj as Service;

            if (other == null)
                return false;

            return this.serviceName == other.serviceName;
        }

        //override GetHashCode method
        public override int GetHashCode()
        {
            return serviceName.GetHashCode();
        }


    }
}