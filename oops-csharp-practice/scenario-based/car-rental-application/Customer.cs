using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class Customer
    {
        //private variables
        private int customerId;

        private string name;

        //parameterized constructor
        public Customer(int customerId, string name)
        {
            this.customerId = customerId;
            this.name = name;
        }

        //method to display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\nCUSTOMER ID: " + customerId);

            Console.WriteLine("CUSTOMER NAME: " + name);
        }
    }
}
