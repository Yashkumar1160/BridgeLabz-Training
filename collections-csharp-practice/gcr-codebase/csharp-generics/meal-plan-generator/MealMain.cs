using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.meal_plan_generator
{
    internal class MealMain
    {
        public static void Main(string[] args)
        {
            //take number of meals
            Console.Write("Enter number of meals: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //generic meal storage using interface type
            Meal<IMealPlan> mealPlan = new Meal<IMealPlan>(size);

            //loop to display choices and add meals 
            for (int i = 0; i < size; i++)
            {
                //display choices
                Console.WriteLine("\n1. Vegetarian");
                Console.WriteLine("2. Vegan");
                Console.Write("Choose meal type: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //take meal name
                Console.Write("Enter meal name: ");
                string name = Console.ReadLine();

                //vegetarian meal
                if (choice == 1)
                {
                    VegetarianMeal veg = new VegetarianMeal(name);
                    MealUtility.GenerateMeal(veg);
                    mealPlan.AddMeal(veg);
                }
                //vegan meal
                else if (choice == 2)
                {
                    VeganMeal vegan = new VeganMeal(name);
                    MealUtility.GenerateMeal(vegan);
                    mealPlan.AddMeal(vegan);
                }
                //invalid choice
                else
                {
                    Console.WriteLine("Invalid choice");
                    i--;
                }
            }

            //display all meals
            Console.WriteLine("\nFINAL MEAL PLAN:");
            mealPlan.DisplayMeals();
        }
    }
}
