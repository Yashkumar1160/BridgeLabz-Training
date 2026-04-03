using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_rankings
{
    internal interface IFitness
    {
        //method to generate random data
        public void GenerateRandomData();

        
        //method to sort person data based on steps using bubble sort
        public void BubbleSort();

        
        //method to swap persons in array
        public void Swap(int i, int j);

        
        //method to check if a person data exists in array
        public bool SearchPerson(string personName);

        
        //method to update steps of a person
        public void UpdateData(string personName, int steps);

        
        //method to display person by rankings
        public void DisplayByRank();


        //method to display each person data
        public void DisplayData();


        //method to display total persons count
        public void DisplayTotalPerson();
    }
}
