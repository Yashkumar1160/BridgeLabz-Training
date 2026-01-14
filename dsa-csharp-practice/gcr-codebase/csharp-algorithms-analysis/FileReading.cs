using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_algorithms_analysis
{
    internal class FileReading
    {
        public static void Main(string[] args)
        {

            //start time for stream reader
            DateTime srStart = DateTime.Now;

            StreamReader reader = new StreamReader("sample.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                //reading line by line
            }

            //end time for stream reader
            DateTime srEnd = DateTime.Now;

            Console.WriteLine("StreamReader TIME: " + (srEnd - srStart).TotalMilliseconds + " ms");

            reader.Close();
            Console.WriteLine("FILE READ USING StreamReader");


            //start time for file stream
            DateTime fsStart = DateTime.Now;

            FileStream fs = new FileStream("sample.txt", FileMode.Open);
            byte[] buffer = new byte[1024];

            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                //reading raw bytes
            }

            //end time for file stream
            DateTime fsEnd = DateTime.Now;
            Console.WriteLine("FileStream TIME: " + (fsEnd - fsStart).TotalMilliseconds + " ms");

            fs.Close();
            Console.WriteLine("FILE READ USING FileStream");
        }
    }
}
