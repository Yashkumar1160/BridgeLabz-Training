using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //call HospitalManagementSystem method
            HospitalManagementSystem();
        }

        //method to start hospital management system application
        public static void HospitalManagementSystem()
        {
            Console.WriteLine("HOSPITAL MANAGEMENT SYSTEM");

            //create object of Hospital class
            Hospital hospital = new Hospital();

            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. Add InPatient");
                Console.WriteLine("2. Add OutPatient");
                Console.WriteLine("3. View All Patients");
                Console.WriteLine("4. Generate Bill");
                Console.WriteLine("5. Discharge Patient");
                Console.WriteLine("6. Exit");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                if (choice == 1)
                {
                    //read patient id
                    Console.Write("ENTER PATIENT ID: ");
                    string id = Console.ReadLine();

                    //read patient name
                    Console.Write("ENTER NAME: ");
                    string name = Console.ReadLine();

                    //read patient age
                    Console.Write("ENTER AGE: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    //check age by using CheckAge method from utility class
                    if (!UtilityClass.CheckAge(age))
                    {
                        Console.WriteLine("INVALID AGE");

                        continue;
                    }

                    //read days
                    Console.Write("DAYS: ");
                    int days = Convert.ToInt32(Console.ReadLine());

                    //read room charge
                    Console.Write("ROOM CHARGE: ");
                    double charge = Convert.ToDouble(Console.ReadLine());

                    //call AddPatient method
                    hospital.AddPatient(new InpatientImpl(id, name, age, days, charge));

                    Console.WriteLine("INPATIENT ADDED");
                }
                else if (choice == 2)
                {
                    //read patient id
                    Console.Write("ENTER PATIENT ID: ");
                    string id = Console.ReadLine();

                    //read patient name
                    Console.Write("ENTER NAME: ");
                    string name = Console.ReadLine();

                    //read patient age
                    Console.Write("ENTER PATIENT AGE: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    //read consultation fee
                    Console.Write("CONSULTATION FEE: ");
                    double fee = Convert.ToDouble(Console.ReadLine());

                    //call AddPatient method
                    hospital.AddPatient(new OutpatientImpl(id, name, age, fee));
                    Console.WriteLine("OUTPATIENT ADDED");
                }
                else if (choice == 3)
                {
                    //call ViewAllPatients method
                    hospital.ViewAllPatients();
                }
                else if (choice == 4)
                {
                    //read patient id
                    Console.Write("ENTER PATIENT ID: ");
                    string patientid = Console.ReadLine();

                    //find patient using FindPatient method
                    Patient patient = hospital.FindPatient(patientid);

                    //use is operator
                    if (patient is IPayable payable)
                    {
                        Bill.GenerateBill(payable);
                    }
                    else
                    {
                        Console.WriteLine("PATIENT NOT FOUND");
                    }
                }
                else if (choice == 5)
                {
                    //read patient id
                    Console.Write("ENTER PATIENT ID: ");
                    string patientId = Console.ReadLine();

                    //find patient using FindPatient method
                    Patient patient = hospital.FindPatient(patientId);
                    if (patient != null)
                    {
                        //discharge patient
                        patient.Discharge(patientId);
                        Console.WriteLine("PATIENT DISCHARGED");
                    }
                    else
                    {
                        Console.WriteLine("PATIENT NOT FOUND");
                    }
                }
                else if (choice == 6)
                {
                    Console.WriteLine("THAKNYOU FOR VISITING");
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID CHOICE");
                }
            }
        }
    }
}
