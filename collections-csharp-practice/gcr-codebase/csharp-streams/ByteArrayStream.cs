using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class ByteArrayStream
    {
        public static void Main(string[] args)
        {
            //source image file path
            string sourceImage = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\insung-yoon-Z7mZmP9AZc8-unsplash.jpg";

            //destination image file path
            string destinationImage = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\takashi-s-NWOMbeQxlaU-unsplash.jpg";

            //try block
            try
            {
                //check if source image exists
                if (!File.Exists(sourceImage))
                {
                    Console.WriteLine("\nSource image not found");
                    return;
                }

                //read image into byte array
                byte[] imageBytes = File.ReadAllBytes(sourceImage);

                //create memory stream using byte array
                MemoryStream memoryStream = new MemoryStream(imageBytes);

                //write byte array back to new image file
                File.WriteAllBytes(destinationImage, memoryStream.ToArray());

                Console.WriteLine("\nImage converted to byte array and saved successfully");

                //verify file size to confirm identical copy
                long originalSize = new FileInfo(sourceImage).Length;
                long newSize = new FileInfo(destinationImage).Length;

                if (originalSize == newSize)
                {
                    Console.WriteLine("Verification Successful: Images are identical");
                }
                else
                {
                    Console.WriteLine("Verification Failed: Images are different");
                }

                //close memory stream
                memoryStream.Close();
            }
            //catch IO exception
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
