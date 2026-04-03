using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class FileNotFoundExample
    {
        public static void Main(string[] args)
        {
            //try block
            try
            {
                //read all text from the file
                string content = File.ReadAllText("data.txt");
                Console.WriteLine(content);
            }
            //catch FileNotFoundException
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException occurred");
            }
            //catch IOException
            catch (IOException ex)
            {
                Console.WriteLine("IOException occurred: " + ex.Message);
            }
        }
    }
}
