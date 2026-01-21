using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class RotateElements
    {
        public static void Main(string[] args)
        {
            //take number of elements
            Console.Write("Enter Number Of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //list to store numbers
            List<int> numbers = new List<int>();

            //loop to take number inputs
            for (int i = 0; i < numberOfElements; i++)
            {
                //take number
                Console.Write("Enter Number: ");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.Add(value);
            }

            //take rotate count
            Console.Write("Enter Rotate Count: ");
            int rotateBy = Convert.ToInt32(Console.ReadLine());

            //call RotateList method
            RotateList(numbers, rotateBy);
        }

        //method to rotate list
        public static void RotateList(List<int> numbers, int rotateBy)
        {
            //store rotated list
            List<int> rotatedList = new List<int>();

            //add elements from rotate position
            for (int i = rotateBy; i < numbers.Count; i++)
            {
                rotatedList.Add(numbers[i]);
            }

            //add first elements at end
            for (int i = 0; i < rotateBy; i++)
            {
                rotatedList.Add(numbers[i]);
            }

            //display rotated list
            Console.WriteLine("Rotated List:");
            foreach (int num in rotatedList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
