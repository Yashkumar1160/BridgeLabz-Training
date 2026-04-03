using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.smart_warehouse_management
{
    internal abstract class WareHouseItem
    {
        //attributes
        string name;
        double price;

        //getters and setters
        public string Name { get; set; }

        public double Price { get; set;  }

        //constructor
        public WareHouseItem(string name, double price)
        {
            Name=name;
            Price=price;
        }

        //abstract method to display item info
        public abstract void DisplayInfo();
    }
}
