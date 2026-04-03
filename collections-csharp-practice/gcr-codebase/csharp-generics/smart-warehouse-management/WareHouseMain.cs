using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.smart_warehouse_management
{
    internal class WareHouseMain
    {
        public static void Main(string[] args)
        {
            //take total items
            Console.Write("ENTER NUMBER OF ITEMS (each): ");
            int size = Convert.ToInt32(Console.ReadLine());

            //generic storage type
            Storage<WareHouseItem> storage = new Storage<WareHouseItem>(size * 2);

            //take electronics items
            Console.WriteLine("\nELECTRONICS ITEMS: ");

            //loop to take electronic items
            for (int i = 0; i < size; i++)
            {
                //take name
                Console.Write("\nEnter name: ");
                string name = Console.ReadLine();

                //take price
                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                //add item
                storage.AddItem(new Electronics(name, price));
            }

            //take groceries items
            Console.WriteLine("\nGROCERIES ITEMS: ");

            for (int i = 0; i < size; i++)
            {
                //take name
                Console.Write("\nEnter name: ");
                string name = Console.ReadLine();

                //take price
                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                //add item
                storage.AddItem(new Groceries(name, price));
            }

            //display items
            storage.DisplayItems();
        }
    }
}
