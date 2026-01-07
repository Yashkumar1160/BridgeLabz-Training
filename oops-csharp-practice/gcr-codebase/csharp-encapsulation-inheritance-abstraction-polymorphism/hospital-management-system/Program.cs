using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.hospital_management_system
{
    internal class Program
    {
        static void Main()
        {
            Start();
        }

        //method to start program
        static void Start()
        {
            //create object of HospitalManager class
            HospitalManager manager = new HospitalManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n--- HOSPITAL PATIENT MANAGEMENT ---");
                Console.WriteLine("1. ADD INPATIENT");
                Console.WriteLine("2. ADD OUTPATIENT");
                Console.WriteLine("3. VIEW ALL PATIENTS");
                Console.WriteLine("4. ADD MEDICAL RECORD");
                Console.WriteLine("5. VIEW MEDICAL RECORDS");
                Console.WriteLine("6. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddInPatient(manager);
                        break;

                    case 2:
                        AddOutPatient(manager);
                        break;

                    case 3:
                        Console.WriteLine("PATIENT DETAILS: ");
                        manager.DisplayAllPatients();
                        break;

                    case 4:
                        AddMedicalRecord(manager);
                        break;

                    case 5:
                        ViewMedicalRecords(manager);
                        break;

                    case 6:
                        Console.WriteLine("\nTHANKYOU");
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
            }
        }


        //method to add in-patient
        static void AddInPatient(HospitalManager manager)
        {
            //take patient id
            Console.Write("Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take patient name
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //take patient age
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //take days admitted
            Console.Write("Days Admitted: ");
            int days = Convert.ToInt32(Console.ReadLine());

            //create object of InPatientImpl class
            InPatientImpl patient = new InPatientImpl(id, name, age, days);

            //set diagnosis
            Console.Write("Diagnosis: ");
            patient.SetDiagnosis(Console.ReadLine());

            //set medical history
            Console.Write("Medical History: ");
            patient.SetMedicalHistory(Console.ReadLine());

            //add patient
            manager.AddPatient(patient);
            Console.WriteLine("InPatient Added Successfully!");
        }

        static void AddOutPatient(HospitalManager manager)
        {
            //take patient id
            Console.Write("Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take patient name
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //take patient age
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //create object of OutPatientImpl class
            OutPatientImpl patient = new OutPatientImpl(id, name, age);

            //set diagnosis
            Console.Write("Diagnosis: ");
            patient.SetDiagnosis(Console.ReadLine());

            //set medical history
            Console.Write("Medical History: ");
            patient.SetMedicalHistory(Console.ReadLine());

            //add patient
            manager.AddPatient(patient);
            Console.WriteLine("OutPatient Added Successfully!");
        }

        //method to add medical record
        static void AddMedicalRecord(HospitalManager manager)
        {
            //take patient id
            Console.Write("Enter Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //call FindPatient method
            Patient patient = manager.FindPatient(id);

            if (patient == null)
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            if (patient is IMedicalRecord recordable)
            {
                Console.Write("Enter Record: ");
                string record = Console.ReadLine();
                recordable.AddRecord(record);
            }
        }


        //method to view medical records 
        static void ViewMedicalRecords(HospitalManager manager)
        {
            //take patient id
            Console.Write("Enter Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //call FindPatient method
            Patient patient = manager.FindPatient(id);

            if (patient == null)
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            if (patient is IMedicalRecord recordable)
            {
                recordable.ViewRecords();
            }
        }
    }
}