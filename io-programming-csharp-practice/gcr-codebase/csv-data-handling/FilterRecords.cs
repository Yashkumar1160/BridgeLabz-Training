using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class FilterRecords
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            //try block
            try
            {
                //StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //skip header row
                    reader.ReadLine();

                    //variable to store line
                    string line;

                    Console.WriteLine("Students scoring more than 80 marks:");

                    //loop to read each line
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split CSV line
                        string[] data = line.Split(',');

                        int marks = int.Parse(data[3]);

                        //check if marks is greater than 80
                        if (marks > 80)
                        {
                            Console.WriteLine("ID    : " + data[0]);
                            Console.WriteLine("Name  : " + data[1]);
                            Console.WriteLine("Marks : " + data[3]);
                            Console.WriteLine("----------------------");
                        }
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

