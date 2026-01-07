using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.online_food_delivery_system
{
    internal class FoodManager
    {
        //array to store food item
        private FoodItem[] items = new FoodItem[50];

        //variable to count total food items
        private int totalFoodItems = 0;

        //method to add item
        public void AddItem(FoodItem item)
        {
            items[totalFoodItems++] = item;
        }


        //method to display all food items
        public void DisplayAllItems()
        {
            if (totalFoodItems == 0)
            {
                Console.WriteLine("No items added yet.");
                return;
            }

            for (int i = 0; i < totalFoodItems; i++)
            {
                items[i].GetItemDetails();
                if (items[i] is IDiscountable discountable)
                {
                    Console.WriteLine(discountable.GetDiscountDetails());
                }
                Console.WriteLine("TOTAL PRICE: " + items[i].CalculateTotalPrice());
            }
        }
    }
}
