using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.meal_plan_generator
{
    internal class VeganMeal : IMealPlan 
    {
        //variable to store meal name
        string mealName;

        //getter and setter
        public string MealName { get; set; }

        //constructor
        public VeganMeal(string mealName)
        {
            MealName = mealName;
        }

        //implementation of DisplayMeal method
        public void DisplayMeal()
        {
            Console.WriteLine("Vegan Meal: " + MealName);
        }
    }
}
