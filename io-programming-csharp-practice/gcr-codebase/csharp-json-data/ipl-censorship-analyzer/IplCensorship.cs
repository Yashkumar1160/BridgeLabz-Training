using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IPLCensorship
{
    internal class IplCensorship
    {
        public static void Main()
        {
            //file paths
            string jsonInputPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\ipl-censorship-analyzer\\JsonInput.json";
            string jsonOutputPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\ipl-censorship-analyzer\\JsonCensored.json";

            string csvInputPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\ipl-censorship-analyzer\\CsvInput.csv";
            string csvOutputPath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\ipl-censorship-analyzer\\CsvCensored.csv";

            //process json file
            CensorJson(jsonInputPath, jsonOutputPath);

            //process csv file
            CensorCsv(csvInputPath, csvOutputPath);

            Console.WriteLine("Censorship completed successfully");
        }

        //method to censor json data
        static void CensorJson(string inputPath, string outputPath)
        {
            //read json file
            string jsonData = File.ReadAllText(inputPath);

            //parse json array
            JArray matches = JArray.Parse(jsonData);

            //loop through each match
            foreach (JObject match in matches)
            {
                //mask team names
                match["team1"] = MaskTeam(match["team1"].ToString());
                match["team2"] = MaskTeam(match["team2"].ToString());

                //mask winner name
                match["winner"] = MaskTeam(match["winner"].ToString());

                //redact player of the match
                match["player_of_match"] = "REDACTED";

                //handle score object
                JObject scoreObj = (JObject)match["score"];
                JObject newScoreObj = new JObject();

                foreach (var score in scoreObj)
                {
                    //mask team name inside score
                    string maskedTeam = MaskTeam(score.Key);
                    newScoreObj[maskedTeam] = score.Value;
                }

                //replace old score object
                match["score"] = newScoreObj;
            }

            //write censored json to file
            File.WriteAllText(outputPath, matches.ToString());

            Console.WriteLine("JSON file censored");
        }

        //method to censor csv data
        static void CensorCsv(string inputPath, string outputPath)
        {
            //read all lines from csv
            string[] lines = File.ReadAllLines(inputPath);

            //create writer for output csv
            StreamWriter writer = new StreamWriter(outputPath);

            //write header as it is
            writer.WriteLine(lines[0]);

            //process remaining rows
            for (int i = 1; i < lines.Length; i++)
            {
                //split row by comma
                string[] cols = lines[i].Split(',');

                //mask team names
                cols[1] = MaskTeam(cols[1]);
                cols[2] = MaskTeam(cols[2]);

                //mask winner
                cols[5] = MaskTeam(cols[5]);

                //redact player of the match
                cols[6] = "REDACTED";

                //write updated row
                writer.WriteLine(string.Join(",", cols));
            }

            writer.Close();
            Console.WriteLine("CSV file censored");
        }

        //method to mask team name
        static string MaskTeam(string teamName)
        {
            //split team name by space
            string[] parts = teamName.Split(' ');

            //replace middle or last part with ***
            if (parts.Length > 1)
            {
                parts[1] = "***";
            }

            //join and return masked name
            return string.Join(" ", parts);
        }
    }
}
