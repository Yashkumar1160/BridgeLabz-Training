using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class CsvToObjects
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            //list to store student objects
            List<Student> students = new List<Student>();

            //try block
            try
            {
                //StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //skip header row
                    reader.ReadLine();

                    //variable to store each line
                    string line;

                    //loop to read each row
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split csv line
                        string[] data = line.Split(',');

                        //create student object
                        Student student = new Student(int.Parse(data[0]), data[1], int.Parse(data[2]), int.Parse(data[3]));

                        //add object to list
                        students.Add(student);
                    }
                }
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // print student objects
            foreach (Student s in students)
            {
                Console.WriteLine(s);
                Console.WriteLine("---------------------");
            }
        }
    }
}
