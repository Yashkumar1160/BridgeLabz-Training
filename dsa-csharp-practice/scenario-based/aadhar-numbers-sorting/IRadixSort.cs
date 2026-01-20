using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_numbers_sorting
{
    internal interface IRadixSort
    {
        //method for radix sort
        void RadixSort();

        //method for counting sort
        void CountingSort(long place);

        //method to add person details
        void AddPersonDetails();

        //method to sort by aadhar numbers
        void SortByAadharNumbers();

        //method to display person details
        void DisplayDetails();

        //method to add multiple person details
        void AddMultiplePerson();

        //method to search for a aadhar number using binary search
        void SearchAadharNumber();

    }
}
