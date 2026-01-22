using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class PipedStreams
    {
        public static void Main(string[] args)
        {
            //try block
            try
            {
                //create pipe server for writing
                AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out);

                //create pipe client for reading
                AnonymousPipeClientStream pipeClient =
                    new AnonymousPipeClientStream(PipeDirection.In,
                    pipeServer.GetClientHandleAsString());

                //create writer thread
                Thread writerThread = new Thread(() => WriteData(pipeServer));

                //create reader thread
                Thread readerThread = new Thread(() => ReadData(pipeClient));

                //start threads
                writerThread.Start();
                readerThread.Start();

                //wait for threads to finish
                writerThread.Join();
                readerThread.Join();
            }
            //catch block
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }

        //method to write data into pipe
        public static void WriteData(AnonymousPipeServerStream server)
        {
            //try block
            try
            {
                StreamWriter writer = new StreamWriter(server);
                writer.AutoFlush = true;

                //write messages
                writer.WriteLine("Hello from Writer Thread");
                writer.WriteLine("Piped Streams Example");
                writer.WriteLine("End");

                //close writer
                writer.Close();
            }
            //catch block
            catch (IOException ex)
            {
                Console.WriteLine("\nWriter IOException: " + ex.Message);
            }
        }

        //method to read data from pipe
        public static void ReadData(AnonymousPipeClientStream client)
        {
            //try block
            try
            {
                StreamReader reader = new StreamReader(client);

                string line;

                //read data line by line
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Reader received: " + line);
                }

                //close reader
                reader.Close();
            }
            //catch block
            catch (IOException ex)
            {
                Console.WriteLine("\nReader IOException: " + ex.Message);
            }
        }
    }
}
