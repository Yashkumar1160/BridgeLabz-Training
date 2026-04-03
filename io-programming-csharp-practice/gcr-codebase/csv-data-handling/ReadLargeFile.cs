using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class ReadLargeFile
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\LargeFile.csv";

            //variable to count total records
            int totalRecords = 0;

            //try block
            try
            {
                //StreamReader for reading file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //skip header row
                    reader.ReadLine();

                    //variable to store each line
                    string line;

                    //counter for batch processing
                    int batchCount = 0;

                    //loop until file ends
                    while ((line = reader.ReadLine()) != null)
                    {
                        totalRecords++;

                        //increase batch count
                        batchCount++;

                        //if 100 lines are read
                        if (batchCount == 100)
                        {
                            //display processed records count
                            Console.WriteLine("Processed Records: " + totalRecords);

                            //reset batch count
                            batchCount = 0;
                        }
                    }

                    //print remaining records if less than 100
                    if (batchCount > 0)
                    {
                        Console.WriteLine("Processed Records: " + totalRecords);
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
