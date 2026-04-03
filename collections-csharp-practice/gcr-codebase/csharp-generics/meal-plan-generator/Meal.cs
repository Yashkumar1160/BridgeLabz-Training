using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.meal_plan_generator
{
    internal class Meal<T> where T : IMealPlan 
    {
        //array to store meals
        T[] meals;

        //variable to store total meals count
        int count = 0;

        //constructor
        public Meal(int size)
        {
            meals = new T[size];
        }

        //method to add meal
        public void AddMeal(T meal)
        {
            meals[count++] = meal;
        }

        //method to display all meals
        public void DisplayMeals()
        {
            for (int i = 0; i < count; i++)
            {
                meals[i].DisplayMeal();
            }
        }
    }
}
