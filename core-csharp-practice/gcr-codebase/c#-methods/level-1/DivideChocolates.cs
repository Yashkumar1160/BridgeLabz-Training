using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class DivideChocolates
    {
        public static void Main(string[] args)
        {
            //take input for number of chocolates
            Console.WriteLine("Enter number of chocolates:");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            //take input for number of students
            Console.WriteLine("Enter number of students:");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //call method
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfStudents);

            //display result
            Console.WriteLine("Each child gets : " + result[0]);
            Console.WriteLine("Remaining chocolates : " + result[1]);
        }
        //Method to find quotient and remainder
        public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfStudents)
        {
            //create integer array to store distributed and remaining chocolates
            int[] result = new int[2];
            result[0] = numberOfChocolates / numberOfStudents;
            result[1] = numberOfChocolates % numberOfStudents;
            //return result array
            return result;
        }
    }
}
