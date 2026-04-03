using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.smart_warehouse_management
{
    internal class Electronics : WareHouseItem 
    {
        //constructor
        public Electronics(string name, double price) : base(name, price){ }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\nElectronics:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);

        }
    }
}
