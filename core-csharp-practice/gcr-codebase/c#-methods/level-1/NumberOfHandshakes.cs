using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class NumberOfHandshakes
    {
        //Method to calculate total number of handshakes
        public int CalculateHandshakes(int numberOfStudents)
        {
            int totalHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
            //return total handshakes
            return totalHandshakes;
        }
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter number of students");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //create an instance of class
            NumberOfHandshakes handshakes = new NumberOfHandshakes();

            //call the  CalculateHandshakes() method
            int totalHandshakes = handshakes.CalculateHandshakes(numberOfStudents);
            //display result
            Console.WriteLine("Total possible number of handshakes are " + totalHandshakes);


        }
    }
}
