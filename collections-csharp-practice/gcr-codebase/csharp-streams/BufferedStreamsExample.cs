using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class BufferedStreamsExample
    {
        public static void Main(string[] args)
        {
            //store source file path
            string sourcePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Source.txt";

            //store destination path for normal stream
            string normalDestPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Destination.txt";

            //store destination path for buffered stream
            string bufferedDestPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\BufferDestination.txt";

            //buffer size of 4KB
            int bufferSize = 4096;

            //try block
            try
            {
                //check if source file exists
                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("\nSource file not found");
                    return;
                }

                //create object of StopWatch class
                Stopwatch normalWatch = new Stopwatch();

                //start timing for normal file stream
                normalWatch.Start();

                //normal file stream copy
                FileStream normalRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
                FileStream normalWrite = new FileStream(normalDestPath, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[bufferSize];
                int bytesRead;

                //loop to read and write using normal filestream
                while ((bytesRead = normalRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    normalWrite.Write(buffer, 0, bytesRead);
                }

                //close normal streams
                normalRead.Close();
                normalWrite.Close();

                //stop stopwatch
                normalWatch.Stop();

                //create object of StopWatch class for buffered stream
                Stopwatch bufferedWatch = new Stopwatch();

                //start timing buffered stream
                bufferedWatch.Start();

                //buffered stream copy
                FileStream fileRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
                FileStream fileWrite = new FileStream(bufferedDestPath, FileMode.Create, FileAccess.Write);

                BufferedStream bufferedRead = new BufferedStream(fileRead, bufferSize);
                BufferedStream bufferedWrite = new BufferedStream(fileWrite, bufferSize);

                //read and write using buffered stream
                while ((bytesRead = bufferedRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedWrite.Write(buffer, 0, bytesRead);
                }

                //flush and close buffered streams
                bufferedWrite.Flush();
                bufferedRead.Close();
                bufferedWrite.Close();
                fileRead.Close();
                fileWrite.Close();

                //stop stopwatch
                bufferedWatch.Stop();

                //display time
                Console.WriteLine("\nNormal Stream Time (ms): " + normalWatch.ElapsedMilliseconds);
                Console.WriteLine("Buffered Stream Time (ms): " + bufferedWatch.ElapsedMilliseconds);
            }
            //catch IO exception
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
