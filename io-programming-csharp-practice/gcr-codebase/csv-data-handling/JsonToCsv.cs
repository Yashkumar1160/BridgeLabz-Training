using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class JsonToCsv
    {
        public static void Main()
        {
            //json file path
            string jsonPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Sample.json";

            //csv file path
            string csvPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Sample.csv";

            //output json file path
            string outputJsonPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\StudentsFromCsv.json";

            //convert json to csv
            ConvertJsonToCsv(jsonPath, csvPath);

            //convert csv back to json
            CsvToJson(csvPath, outputJsonPath);
        }

        //method to convert json to csv
        static void ConvertJsonToCsv(string jsonPath, string csvPath)
        {
            //read json file content
            string jsonData = File.ReadAllText(jsonPath);

            //deserialize json into student list
            List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonData);

            //StreamWriter to write csv
            using (StreamWriter writer = new StreamWriter(csvPath))
            {
                //write csv header
                writer.WriteLine("Id,Name,Age,Marks");

                //loop through student list
                foreach (Student s in students)
                {
                    //write each student record
                    writer.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Marks}");
                }
            }

            Console.WriteLine("JSON to CSV conversion completed.");
        }

        //method to convert csv to json
        static void CsvToJson(string csvPath, string jsonPath)
        {
            //list to store student objects
            List<Student> students = new List<Student>();

            //StreamReader to read csv file
            using (StreamReader reader = new StreamReader(csvPath))
            {
                //skip header row
                reader.ReadLine();

                //variable to store each line
                string line;

                //read csv rows
                while ((line = reader.ReadLine()) != null)
                {
                    //split csv line
                    string[] data = line.Split(',');

                    //create student object
                    Student student = new Student
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Age = int.Parse(data[2]),
                        Marks = int.Parse(data[3])
                    };

                    //add to list
                    students.Add(student);
                }
            }

            //serialize list to json
            string jsonData = JsonSerializer.Serialize(students, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            //write json to file
            File.WriteAllText(jsonPath, jsonData);

            Console.WriteLine("CSV to JSON conversion completed.");
        }
    }
}
