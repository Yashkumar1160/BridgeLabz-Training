using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.emergency_patient_navigation
{
    internal class Hospital
    {
        //head node
        HospitalUnit head;


        //method to add a unit
        public void AddUnit(string unitName,bool isAvailable)
        {
            //create new node
            HospitalUnit newUnit = new HospitalUnit(unitName, isAvailable);

            //if no unit exits
            if (head == null)
            {
                head = newUnit;
                newUnit.Next = head;
                return;
            }

            //store head in temp variable
            HospitalUnit temp = head;

            //loop through list
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            //add new unit
            temp.Next = newUnit;
            newUnit.Next = head;

            Console.WriteLine("\nUnit Added Successfully");
        }

        //method to redirect patient
        public void RedirectPatient()
        {
            //if no unit exits
            if (head == null)
            {
                Console.WriteLine("\nNo Units Available");
                return;
            }

            //store head in temp variable
            HospitalUnit temp = head;

            //loop through list
            while (true)
            {
                //if status is available
                if (temp.isAvailable)
                {
                    Console.WriteLine("\nUnit Available is: " + temp.unitName);
                    return;
                }

                //update temp
                temp = temp.Next;

                if (temp == head)
                    break;
            }

            Console.WriteLine("\nNo Unit is Available");
        }

        //method to update unit status
        public void UpdateUnit(string unitName,bool status)
        {
            //if no unit exists
            if (head == null)
            {
                Console.WriteLine("\nNo Units Available");
                return;
            }

            //store head in temp variable
            HospitalUnit temp = head;

            //loop through list
            while (true)
            {
                //if unit name is found
                if (temp.unitName.Equals(unitName, StringComparison.OrdinalIgnoreCase))
                {
                    temp.isAvailable = status;
                    Console.WriteLine("\nStatus Updated Successfully");
                    return;
                }

                //update temp
                temp = temp.Next;

                if (temp == head)
                    break;
            }

            Console.WriteLine("\nUnit Not Found");
        }


        //method to remove unit
        public void RemoveUnit(string unitName)
        {
            //if no unit is added
            if (head == null)
            {
                Console.WriteLine("\nNo Units Available");
                return;
            }

            //store current node
            HospitalUnit current = head;

            //store previous node
            HospitalUnit prev = null;


            //loop through list
            while (true)
            {
                //if unit is found
                if (current.unitName.Equals(unitName, StringComparison.OrdinalIgnoreCase))
                {
                    //single node case
                    if (current == head && current.Next == head)
                    {
                        head = null;
                    }
                    //removing head
                    else if (current == head)
                    {
                        HospitalUnit last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    Console.WriteLine(unitName + " Removed Successfully");
                    return;
                }

                //update prev and current
                prev = current;
                current = current.Next;

                if (current == head)
                    break;
            }

            Console.WriteLine("\nUnit Not Found");
        }


        //method to display list
        public void DisplayUnits()
        {
            if (head == null)
            {
                Console.WriteLine("\nNo Units Available");
                return;
            }

            HospitalUnit temp = head;

            while (true)
            {
                Console.WriteLine(temp);

                temp = temp.Next;

                if (temp == head)
                    break;
            }
        }
    }
}
