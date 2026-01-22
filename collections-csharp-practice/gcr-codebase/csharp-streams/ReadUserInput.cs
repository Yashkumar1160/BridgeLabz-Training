using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class ReadUserInput
    {
        public static void Main(string[] args)
        {
            //file path to store user data
            string userInputs = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\UserInputs.txt";

            //try block
            try
            {
                //stream reader for console input
                StreamReader reader = new StreamReader(Console.OpenStandardInput());

                //stream writer to write data into file
                StreamWriter writer = new StreamWriter(userInputs);

                //take user name
                Console.Write("ENTER NAME: ");
                string name = reader.ReadLine();

                //take user age
                Console.Write("ENTER AGE: ");
                string age = reader.ReadLine();

                //take a sentence
                Console.Write("ENTER A SENTENCE: ");
                string sentence = reader.ReadLine();

                //write data into file
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Sentence: " + sentence);

                //close streams
                writer.Close();
                reader.Close();

                Console.WriteLine("\nUser details saved successfully");
            }
            //catch block
            catch (IOException ex)
            {
                //display exception 
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
