using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ride_hailing_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stringbuilder_stringbuffer
{
    internal class ReverseString
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.Write("ENTER A STRING: ");
            string stringInput = Console.ReadLine();

            //create object of StringBuilder
            StringBuilder stringBuilder = new StringBuilder(stringInput);

            //call FindReverseString method
            FindReverseString(stringBuilder);
        }


        //method to reverse a string and display it 
        public static void FindReverseString(StringBuilder stringBuilder)
        {
            //initialize start and end index
            int start = 0;
            int end = stringBuilder.Length - 1;

            //loop until start index is less than end index
            while (start < end)
            {
                //swap characters
                char ch = stringBuilder[start];
                stringBuilder[start] = stringBuilder[end];
                stringBuilder[end] = ch;

                start++;
                end--;
            }

            //display reversed string
            Console.WriteLine("REVERSED STRING: " + stringBuilder.ToString());

        }
    }
}
