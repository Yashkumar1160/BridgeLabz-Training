using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.emergency_patient_navigation
{
    internal class AmbulanceRouteUtilityImpl : IAmbulance
    {
        //create object of Hospital class
        Hospital hospital = new Hospital();

        //method to add a unit
        public void AddUnit()
        {
            //take unit name
            Console.Write("\nENTER UNIT NAME: ");
            string unitName = Console.ReadLine();

            //take available status
            Console.Write("\nENTER AVAILABILITY (true/false): ");
            bool isAvailable = Convert.ToBoolean(Console.ReadLine());

            //add unit to circular linked list
            hospital.AddUnit(unitName, isAvailable);
        }

        //method to remove units
        public void RemoveUnit()
        {
            //take unit name
            Console.Write("\nENTER UNIT NAME: ");
            string unitName = Console.ReadLine();

            //call RemoveUnit method
            hospital.RemoveUnit(unitName);
        }

        //method to update unit status
        public void UpdateUnitStatus()
        {
            //take unit name
            Console.Write("\nENTER UNIT NAME: ");
            string unitName = Console.ReadLine();

            //take status
            Console.Write("ENTER STATUS: ");
            bool status = Convert.ToBoolean(Console.ReadLine());

            //update status
            hospital.UpdateUnit(unitName,status);
        }

        //method to redirect patient to another unit
        public void RedirectPatient()
        {
            //call RedirectPatient method from hospital
            hospital.RedirectPatient();
        }


        //method to display all units 
        public void DisplayUnits()
        {
            hospital.DisplayUnits();
        }
    }
}
