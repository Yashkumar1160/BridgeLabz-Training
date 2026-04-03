using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class FileHandling
    {
        public static void Main(string[] args)
        {
            //try block
            try
            {
                //using statement ensures StreamReader is closed automatically
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    //read the first line of the file
                    string line = reader.ReadLine();
                    Console.WriteLine("First line: " + line);
                }
            }
            //catch IOException
            catch (IOException)
            {
                Console.WriteLine("IOException occurred: Error reading file");
            }
        }
    }
}
