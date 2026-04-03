using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class FilterStreams
    {
        public static void Main(string[] args)
        {
            //source file path
            string sourceFile = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Input.txt";

            //destination file path
            string destinationFile = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Output.txt";

            //try block
            try
            {
                //check if source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("\nSource file not found");
                    return;
                }

                //open file stream for reading
                FileStream readStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);

                //open file stream for writing
                FileStream writeStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);

                //use buffered streams for efficiency
                BufferedStream bufferedRead = new BufferedStream(readStream);
                BufferedStream bufferedWrite = new BufferedStream(writeStream);

                //stream reader with UTF8 encoding
                StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8);

                //stream writer with UTF8 encoding
                StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8);

                string line;

                //loop to read file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    //convert uppercase to lowercase
                    string lowerCaseLine = line.ToLower();

                    //write converted line to destination file
                    writer.WriteLine(lowerCaseLine);
                }

                //close all streams
                reader.Close();
                writer.Close();
                bufferedRead.Close();
                bufferedWrite.Close();
                readStream.Close();
                writeStream.Close();

                Console.WriteLine("\nFile converted to lowercase successfully");
            }
            //catch IO exception
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
