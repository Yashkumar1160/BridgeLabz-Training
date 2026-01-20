using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_numbers_sorting
{
    internal class RadixSortUtilityImpl : IRadixSort 
    {
        //array to store person details
        Person[]personDetails=new Person[100];

        //variable to store total person count
        int totalPerson = 0;

        //flag to check if sorted or not
        bool isSorted= false;

        //method for radix sort
        public void RadixSort()
        {
            long place = 1;
            int maxLength = 12;
            for(int i = 0; i < maxLength; i++)
            {
                CountingSort(place);
                place *= 10;
            }
        }

        
        //method for counting sort
        public void CountingSort(long place)
        {
            //array to store count of digits
            int[] count = new int[10];

            //array to store sorted data
            Person[]sortedOutput=new Person[totalPerson];

            //loop to find the digits count
            for (int i = 0; i < totalPerson; i++)
            {
                int digit = (int)((personDetails[i].AadharNumber / place) % 10);
                count[digit]++;
            }

            //loop for prefix sum
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }


            for (int i = totalPerson - 1; i >= 0; i--)
            {
                int digit = (int)((personDetails[i].AadharNumber / place) % 10);
                sortedOutput[count[digit] - 1] = personDetails[i];
                count[digit]--;
            }

            //copy in original array
            for (int i = 0; i < totalPerson; i++)
            {
                personDetails[i] = sortedOutput[i];
            }
        }

        
        //method to add person details
        public void AddPersonDetails()
        {
            //if array is full
            if (totalPerson == personDetails.Length)
            {
                Console.WriteLine("\nMAXIMUM LIMIT REACHED");
                return;
            }

            //take name
            Console.Write("\nENTER NAME: ");
            string name=Console.ReadLine();

            //take age
            Console.Write("ENTER AGE: ");
            int age=Convert.ToInt32(Console.ReadLine());

            //take gender
            Console.Write("ENTER GENDER: ");
            string gender=Console.ReadLine();

            //take aadhar number
            Console.Write("ENTER AADHAR NUMBER: ");
            string aadhar=Console.ReadLine();

            //check valid aadhar number input
            if (aadhar.Length != 12)
            {
                Console.WriteLine("\nInvalid Aadhar Number");
                return;
            }

            long aadharNumber=Convert.ToInt64(aadhar);

            //create object
            Person person = new Person(name, age, gender, aadharNumber);

            //add person
            personDetails[totalPerson] = person;
            totalPerson++;

            isSorted = false;
            Console.WriteLine("\nPerson Added Successfully");
        }


        //methodt to add details of multiple person
        public void AddMultiplePerson()
        {
            //if array is full
            if (totalPerson == personDetails.Length)
            {
                Console.WriteLine("\nMaximum Limit Reached");
                return;
            }

            //take number of persons
            Console.Write("\nENTER NUMBER OF PERSONS: ");
            int numberOfPersons = Convert.ToInt32(Console.ReadLine());

            //loop to take details of person and add 
            for(int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("\nEnter Details Of Person " + (i + 1));
                AddPersonDetails();
            }
        }



        //method to sort by aadhar numbers
        public void SortByAadharNumbers()
        {
            //if no person detail is added
            if (totalPerson == 0)
            {
                Console.WriteLine("\nNo Person Details Added Yet");
                return;
            }

            //radix sort
            RadixSort();

            //flag to check if array is sorted or not
            isSorted= true;

            Console.WriteLine("\nSorted By Aadhar Numbers");
        }



        //method to search for a person using aadhar number
        public void SearchAadharNumber()
        {
            //if array is not sorted
            if (!isSorted)
            {
                Console.WriteLine("\nSort By Aadhar Numbers First");
                return;
            }

            //take aadhar number to search
            Console.Write("\nENTER AADHAR NUMBER: ");
            long number=Convert.ToInt64(Console.ReadLine());

            //take low and high pointers
            int low = 0;
            int high = totalPerson-1;

            //loop until low is less than or equal to high
            while(low <= high)
            {
                //find mid index
                int mid = low + (high - low) / 2;

                //check if aadhar number matches matches
                if (personDetails[mid].AadharNumber == number)
                {
                    Console.WriteLine("\nPerson Found: ");
                    Console.WriteLine(personDetails[mid]);
                    return;
                }
                //search left part 
                else if (number < personDetails[mid].AadharNumber)
                {
                    high = mid - 1;
                }
                //search right part
                else {
                    low=mid + 1;
                }
            }

            Console.WriteLine("\nAadhar Number Not Found");
        }



        //method to display person details
        public void DisplayDetails()
        {
            if(totalPerson == 0)
            {
                Console.WriteLine("\nNo Person Details Added Yet");
                return;
            }

            Console.Write("\nDetails Of Every Person: ");

            for(int i = 0;i < totalPerson;i++)
            {
                Console.WriteLine(personDetails[i]);
            }
        }
    }
}
