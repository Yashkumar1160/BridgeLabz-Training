using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.meal_plan_generator
{
    internal class VegetarianMeal : IMealPlan 
    {
        //variable to store meal name
        string mealName;

        //getter and setter
        public string MealName { get; set; }

        //constructor
        public VegetarianMeal(string mealName)
        {
            MealName=mealName;
        }

        //implementation of DisplayMeal method
        public void DisplayMeal()
        {
            Console.WriteLine("Vegetarian Meal: " + MealName);
        }
    }
}
