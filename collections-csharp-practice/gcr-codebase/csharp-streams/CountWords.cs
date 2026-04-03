using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    internal class CountWords
    {
        public static void Main(string[] args)
        {
            //file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\Source.txt";

            //try block
            try
            {
                //check if file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("\nFile not found");
                    return;
                }

                //dictionary to store word count
                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                //open file using StreamReader
                StreamReader reader = new StreamReader(filePath);

                string line;

                //read file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    //split line into words
                    string[] words = line.Split(' ', ',', '.', '!', '?');

                    foreach (string word in words)
                    {
                        //convert word to lowercase
                        string w = word.ToLower();

                        //skip empty words
                        if (w == "")
                            continue;

                        //count word frequency
                        if (wordCount.ContainsKey(w))
                            wordCount[w]++;
                        else
                            wordCount[w] = 1;
                    }
                }

                //close reader
                reader.Close();

                Console.WriteLine("\nTop 5 Most Frequent Words:");

                //sort dictionary by value and take top 5
                foreach (var item in wordCount.OrderByDescending(x => x.Value).Take(5))
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }
            //catch IO exception
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
        }
    }
}
