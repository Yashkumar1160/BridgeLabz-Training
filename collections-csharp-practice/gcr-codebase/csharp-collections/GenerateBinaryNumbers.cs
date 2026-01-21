using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class GenerateBinaryNumbers
    {
        public static void Main(string[] args)
        {
            //take n value
            Console.Write("Enter N value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //call GenerateBinary method
            GenerateBinary(n);
        }

        //method to generate binary numbers
        public static void GenerateBinary(int n)
        {
            //queue to store elements
            Queue<string> queue = new Queue<string>();

            //enqueue first binary number
            queue.Enqueue("1");

            //loop to generate n numbers
            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                Console.Write(current + " ");

                //generate next binary numbers
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }
    }
}
