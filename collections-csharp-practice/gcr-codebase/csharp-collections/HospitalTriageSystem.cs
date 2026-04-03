using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class HospitalTriageSystem
    {
        public static void Main(string[] args)
        {
            //priority queue
            PriorityQueue<string, int> patients = new PriorityQueue<string, int>();

            //add patients with severity (negative for max priority)
            patients.Enqueue("Yash", -3);
            patients.Enqueue("Prashant", -5);
            patients.Enqueue("Varun", -2);

            //call Treatment method
            Treatment(patients);
        }

        //method to treat patients based on priority
        public static void Treatment(PriorityQueue<string, int> patients)
        {
            Console.WriteLine("Treatment Order:");

            while (patients.Count > 0)
            {
                Console.WriteLine(patients.Dequeue());
            }
        }
    }
}
