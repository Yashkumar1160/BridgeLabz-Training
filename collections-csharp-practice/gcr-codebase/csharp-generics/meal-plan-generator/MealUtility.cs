using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.meal_plan_generator
{
    internal class MealUtility
    { 
        //generic method to validate and generate meal
        public static void GenerateMeal<T>(T meal) where T : IMealPlan
        {
            Console.WriteLine("Meal generated successfully:");
            meal.DisplayMeal();
        }
    }
}
