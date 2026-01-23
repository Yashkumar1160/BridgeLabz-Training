using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class MultipleExceptions
    {
        public static void Main(string[] args)
        {
            //initialize array with null
            int[] numbers = null;

            //try block
            try
            {
                //take user input for index
                Console.Write("ENTER INDEX: ");
                int index = int.Parse(Console.ReadLine());

                //get value at given index
                int value = numbers[index];

                //if no exception occurred
                Console.WriteLine("Value at index " + index + ": " + value);
            }
            //catch IndexOutOfRangeException
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException occurred: Invalid index!");
            }
            //catch NullReferenceException
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException occurred: Array is not initialized!");
            }
            //catch FormatException
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter a valid numeric value");
            }
        }
    }
}
