using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_rankings
{
    internal class FitnessUtilityImpl : IFitness 
    {
        //array to store each person data
        Person[] personData = new Person[20];


        //variable to store total person count
        int totalPersons = 0;

        //initially data is not sorted
        bool sorted=false;

        //method to generate random data
        public void GenerateRandomData()
        {
            //create object for Random class
            Random random = new Random();

            //loop to generate person data
            for(int i=0;i<personData.Length; i++)
            {
                string personName = $"Person {i + 1}";
                int steps=random.Next(1000,10000);
                int age = random.Next(8, 100);

                //create object of Person class
                Person person = new Person(personName,steps,age);

                //add person to array
                personData[totalPersons++]=person;
            }
        }



        //method to sort person data based on steps using bubble sort
        public void BubbleSort() 
        { 

            //loop through person data array
            for (int i = 0; i < totalPersons - 1; i++)
            {
                //loop to compare adjacent elements
                for (int j = 0; j < totalPersons - 1 - i; j++)
                {
                    //if steps of current person is greater than steps of next person
                    if (personData[j].Steps < personData[j + 1].Steps)
                    {
                        //call swap method
                        Swap(j, j+1);
                    }
                }
            }
         
            sorted = true;
        }



        //method to swap persons in array
        public void Swap(int i,int j)
        {
            Person temp = personData[i];
            personData[i] = personData[j];
            personData[j] = temp;
        }



        //method to check if a person data exists in array
        public bool SearchPerson(string personName)
        {
            //loop through personData array
            foreach (Person person in personData)
            {
                //if person is found 
                if (person != null && person.PersonName.Equals(personName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }



        //method to update steps of a person
        public void UpdateData(string personName,int steps)
        {
            //loop through personData array
            foreach (Person person in personData)
            {
                //if person is found
                if (person != null && person.PersonName.Equals(personName, StringComparison.OrdinalIgnoreCase))
                {
                    //update steps
                    person.Steps= steps;
                    Console.WriteLine("\nUpdated Successfully");
                    BubbleSort();
                    return;
                }
            }
        }



        //method to display total persons count
        public void DisplayTotalPerson()
        {
            Console.WriteLine("\nTotal Person: " + totalPersons);
        }



        //method to display each person personData
        public void DisplayData()
        {
            Console.WriteLine("\nDetails Of Each Person: ");

            for(int i = 0; i < totalPersons; i++)
            {
                Console.WriteLine(personData[i]);
            }
        }



        //method to display person by rankings
        public void DisplayByRank()
        {
            if (!sorted)
            {
                Console.WriteLine("DATA IS NOT SORTED. PLEASE SORT FIRST");
                return;
            }

            Console.WriteLine("\nDetails Of Each Person By Rank: ");

            for(int i = 0; i < totalPersons; i++)
            {
                Console.WriteLine(personData[i]);
                Console.WriteLine($"Rank: {i + 1}");
            }
        }
    }
}
