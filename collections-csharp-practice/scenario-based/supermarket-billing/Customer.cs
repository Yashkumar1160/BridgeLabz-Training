using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.supermarket_billing
{
    internal class Customer
    {
        //attributes
        string customerName;
        ArrayList items;

        //getter and setter
        public string CustomerName { get; set; }

        public ArrayList Items { get; set; }

        //constructor
        public Customer(string name)
        {
            CustomerName = name;
            Items = new ArrayList();
        }
    }
}
