using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class IndexOutOfRange
    {
        public static void Main(string[] args)
        {
            //call method to generate and handle exception   
            HandleException();

        }
        public static void HandleException()
        {   //try block
            try
            {
                string text = "hello";
                Console.WriteLine(text[10]);
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
