using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class Patient
    {
        //static variables
        public static string hospitalName = "CITY HOSPITAL";

        private static int totalPatients;

        //instance variables
        public readonly string patientId;

        private string name;

        private string ailment;

        private int age;

        //create parameterized constructor
        public Patient(string patientId, string name, int age, string ailment)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            totalPatients++;
        }

        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //display hospital name
            Console.WriteLine(hospitalName);

            //take patient id input
            Console.Write("ENTER PATIENT ID:");
            string patientId = Console.ReadLine();

            //take patient name input
            Console.Write("ENTER PATIENT NAME: ");
            string name = Console.ReadLine();

            //take ailment input
            Console.Write("ENTER  AILMENT: ");
            string ailment = Console.ReadLine();

            //take patient age input
            Console.Write("ENTER AGE: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //create object
            Patient patient = new Patient(patientId, name, age, ailment);


            //check if object is of class type
            if (patient is Patient)
            {
                //call DisplayDetails method
                patient.DisplayDetails();

                //call GetTotalPatients method
                GetTotalPatients();

            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all patient details
        public void DisplayDetails()
        {

            Console.WriteLine("\nPATIENT DETAILS: ");

            Console.WriteLine("PATIENT NAME: " + name);

            Console.WriteLine("PATIENT ID: " + patientId);

            Console.WriteLine("AILMENT: " + ailment);

            Console.WriteLine("PATIENT AGE: " + age);

        }

        //----------GET TOTAL PATIENTS---------------
        //method to get total patients
        public static void GetTotalPatients()
        {
            Console.WriteLine("\nTOTAL PATIENTS: " + totalPatients);

        }

    }
}
