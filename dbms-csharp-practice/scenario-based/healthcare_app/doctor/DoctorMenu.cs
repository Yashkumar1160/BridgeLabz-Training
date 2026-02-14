using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.doctor
{
    public class DoctorMenu
    {
        public static void DisplayMenu()
        {
            IDoctor doctor = new DoctorUtilityImpl();

            while (true)
            {
                Console.WriteLine("----- DOCTOR MENU -----");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Update Doctor Specialty");
                Console.WriteLine("3. View Doctors by Specialty");
                Console.WriteLine("4. Deactivate Doctor");
                Console.WriteLine("5. Back");

                Console.Write("Enter Choice: ");
                string input = Console.ReadLine();
                int choice = int.Parse(input);


                switch (choice)
                {
                    case 1:
                        doctor.AddDoctor();
                        break;

                    case 2:
                        doctor.UpdateDoctorSpecialty();
                        break;

                    case 3:
                        doctor.ViewDoctorsBySpecialty();
                        break;

                    case 4:
                        doctor.DeactivateDoctor();
                        break;
                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}