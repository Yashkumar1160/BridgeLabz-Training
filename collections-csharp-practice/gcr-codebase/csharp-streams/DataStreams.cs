using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class DataStreams
    {
        public static void Main(string[] args)
        {
            //file path to store student data
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\StudentData.bin";

            //try block
            try
            {
                //write student data into binary file
                BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create));

                //student details
                int rollNo = 101;
                string name = "Yash";
                double gpa = 8.5;

                //write data
                writer.Write(rollNo);
                writer.Write(name);
                writer.Write(gpa);

                //close writer
                writer.Close();

                Console.WriteLine("\nStudent data saved successfully");

                //read student data from binary file
                BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open));

                //read data
                int r = reader.ReadInt32();
                string n = reader.ReadString();
                double g = reader.ReadDouble();

                //close reader
                reader.Close();

                //display data
                Console.WriteLine("\nStudent Details:");
                Console.WriteLine("Roll No: " + r);
                Console.WriteLine("Name: " + n);
                Console.WriteLine("GPA: " + g);
            }
            //catch IO exception
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
