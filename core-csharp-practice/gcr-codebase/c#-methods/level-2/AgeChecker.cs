using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class AgeChecker
    {
        public static void Main(string[] args)
        {
            //create integer array to store ages
            int[] ages = new int[10];
            //take user inputs for ages
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine("Enter age of student " + (i + 1));
                ages[i] = Convert.ToInt32(Console.ReadLine());
                //call CheckAge() method
                Console.WriteLine(CheckAge(ages[i]) ? "Can Vote" : "Cannot Vote");
            }
        }
        //Method to check age
        public static bool CheckAge(int age)
        {

            if (age < 0)
            {   //if age is invalid
                return false;
            }
            else
            {
                //return bool value according to age
                return age >= 18;

            }
        }
    }
}
