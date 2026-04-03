using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class CsvToJson
    {
        public static void Main()
        {
            //read csv lines
            string[] lines = File.ReadAllLines("C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\Data.csv");

            //create list for json objects
            var list = new List<object>();

            //skip header row
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                //add row data to list
                list.Add(new
                {
                    name = data[0],
                    age = int.Parse(data[1]),
                    email = data[2]
                });
            }

            //convert list to json
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);

            //display json
            Console.WriteLine(json);
        }
    }
}
