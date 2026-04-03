using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class MaxHandshakes
    {
        public static void Main(string[] args)
        {
            //take input for number of student
            Console.WriteLine("Enter number of students");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //create instance of class
            MaxHandshakes maxHs = new MaxHandshakes();

            //call the Handshakes() method
            int totalHandshakes = maxHs.Handshakes(numberOfStudents);
            //display result
            Console.WriteLine("Maximum number of possible handshakes are : " + totalHandshakes);

        }
        //Method to find total number of possible handshakes
        public int Handshakes(int numberOfStudents)
        {
            int totalHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
            //return total handshakes
            return totalHandshakes;
        }
    }
}
