 using System;
using System.Reflection;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.flip_key
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //take word
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            //get type
            Type type = typeof(StringUtility);

            //create object dynamically
            object obj = Activator.CreateInstance(type);

            //get method using reflection
            MethodInfo method = type.GetMethod("CleanseAndInvert");

            //read annotation using reflection
            FlipKeyAttribute attribute = method.GetCustomAttribute<FlipKeyAttribute>();

            //invoke method dynamically
            string output = (string)method.Invoke(obj, new object[] { input });

            //display result
            if (output == "")
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("The generated key is - " + output);
            }
        }
    }
}
