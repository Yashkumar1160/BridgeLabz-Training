using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class ReadAndCountRows
    {
        public static void Main()
        {
            //file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            //variable to store count
            int count = 0;

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

                    //loop to read each remaining line
                    while ((line = reader.ReadLine()) != null)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Total number of student records: " + count);
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
