using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.supermarket_billing
{
    internal class Item
    {
        //attributes
        string itemName;
        int quantity;
        double price;

        //getter and setter
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        //constructor
        public Item(string itemName,double price,int quantity)
        {
            ItemName=itemName;
            Price = price;
            Quantity = quantity;
        }
    }
}
