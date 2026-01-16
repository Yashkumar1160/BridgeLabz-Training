using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase
{
    internal class JewelsAndStones
    {
        public static void Main(string[] args)
        {
            //take jewels string
            Console.Write("ENTER JEWELS STRING:");
            string jewels = Console.ReadLine();

            //take stones string
            Console.Write("ENTER STONES STRING: ");
            string stones = Console.ReadLine();

            //call NumJewelsInStone method
            NumJewelsInStone(jewels, stones);

        }

        //method to count how many stones are jewels
        public static void NumJewelsInStone(string jewels, string stones)
        {
            //dictionary to store stone character and its frequency
            Dictionary<char, int> stoneCount = new Dictionary<char, int>();

            //loop to count stones
            foreach (char c in stones)
            {
                //if stone already exists in dictionar
                if (stoneCount.ContainsKey(c))
                {
                    //increase count
                    stoneCount[c]++;
                }
                else
                {
                    stoneCount[c] = 1;
                }
            }

            //store total jewels count
            int totalJewels = 0;

            //loop to count jewels
            foreach (char j in jewels)
            {
                //if jewel exists in stones dictionary
                if (stoneCount.ContainsKey(j))
                {
                    totalJewels += stoneCount[j];
                }
            }

            Console.WriteLine("TOTAL JEWELS: " + totalJewels);
        }
    }
}
