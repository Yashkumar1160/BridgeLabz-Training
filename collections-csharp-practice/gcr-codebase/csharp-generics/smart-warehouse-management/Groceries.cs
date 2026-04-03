using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.smart_warehouse_management
{
    internal class Groceries : WareHouseItem 
    {
        //constructor
        public Groceries(string name, double price) : base(name, price) { }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\nGroceries:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);

        }
    }
}
