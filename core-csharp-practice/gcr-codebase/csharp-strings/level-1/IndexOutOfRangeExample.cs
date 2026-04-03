using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class IndexOutOfRangeExample
    {
        public static void Main(string[] args)
        {
            //call the method to generate and handle exception
            ExampleOfIndexOutOfRange();
        }
        //Method to generate and handle IndexOutOfRangeException
        public static void ExampleOfIndexOutOfRange()
        {
            //try block
            try
            {
                int[] nums = { 1, 2, 3, 4 };
                //generate exception
                Console.WriteLine(nums[10]);
            }
            //catch block
            catch (IndexOutOfRangeException)
            {
                //catch exception and display message 
                Console.WriteLine("IndexOutOfRangeException caught");
            }
        }
    }
}
