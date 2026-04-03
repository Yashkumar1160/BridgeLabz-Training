using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class FileHandling
    {
        public static void Main(string[] args)
        {
            //store source file location
            string inputPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Source.txt";

            //store destination file location
            string outputPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Destination.txt";

            //try block
            try
            {
                //check if source file exists
                if (File.Exists(inputPath) == false)
                {
                    Console.WriteLine("\nSource file not found");
                    return;
                }

                //file streams for read and write
                FileStream inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                FileStream outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

                int fileByte = 0;

                //loop to copy data from source to destination
                while (true)
                {
                    fileByte = inputStream.ReadByte();

                    if (fileByte == -1)
                        break;

                    outputStream.WriteByte((byte)fileByte);
                }

                //close streams
                inputStream.Close();
                outputStream.Close();

                Console.WriteLine("\nFile transfer completed successfully");
            }
            //catch block 
            catch (IOException ex)
            {
                //display exception
                Console.WriteLine("\nIOException caught: " + ex.Message);
            }
        }
    }
}
