using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.smart_warehouse_management
{
    internal class Storage<T> where T : WareHouseItem 
    {
        //array to store items
        T[]items=new T[10];

        //variable to store total items count
        int totalItems = 0;

        //constructor
        public Storage(int size)
        {
            items = new T[size];
        }

        //method to add item 
        public void AddItem(T item)
        {
            if (totalItems < items.Length)
            {
                items[totalItems++] = item;
            }
            else
            {
                Console.WriteLine("STORAGE FULL");
            }
        }

        //method to display all items
        public void DisplayItems()
        {
           for(int i = 0; i < totalItems; i++)
            {
                items[i].DisplayInfo();
            }
        }
    }
}
