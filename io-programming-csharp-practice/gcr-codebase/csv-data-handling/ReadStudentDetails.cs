using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class ReadStudentDetails
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            //try block
            try
            {
                //stream reader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //variable to store line
                    string line;

                    //read and skip header line
                    reader.ReadLine();

                    //read file line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split line using comma
                        string[] data = line.Split(',');

                        //display
                        Console.WriteLine("Student ID   : " + data[0]);
                        Console.WriteLine("Student Name : " + data[1]);
                        Console.WriteLine("Age          : " + data[2]);
                        Console.WriteLine("Marks        : " + data[3]);
                        Console.WriteLine("---------------------------");
                    }
                }
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
