using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class ReadLargeFile
    {
        public static void Main(string[] args)
        {
            //large file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\LargeFile.txt";

            //try block
            try
            {
                //check if file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("\nFile not found");
                    return;
                }

                //open file using StreamReader
                StreamReader reader = new StreamReader(filePath);

                string line;

                //read file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    //check if line contains "error" (case insensitive)
                    if (line.ToLower().Contains("error"))
                    {
                        //print matching line
                        Console.WriteLine(line);
                    }
                }

                //close reader
                reader.Close();
            }
            //catch IO exception
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
