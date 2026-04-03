using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.ranksheet_generator
{
    internal class EduResultUtilityImpl
    {
        //list to store states, disricts and students
        ArrayList states = new ArrayList();


        //method to add a state
        public void AddState()
        {
            Console.Write("\nENTER STATE NAME: ");
            string stateName = Console.ReadLine();

            states.Add(new State(stateName));
            
            Console.WriteLine("\nState added successfully!");
        }


        //method to add district
        public void AddDistrict()
        {
            //check if any state exists
            if (states.Count == 0)
            {
                Console.WriteLine("\nAdd State First");
                return;
            }

            //take state name
            Console.Write("\nENTER STATE NAME: ");
            string stateName = Console.ReadLine();

            //flag to check if state exists
            bool stateFound = false;

            //loop to find state
            foreach (State state in states)
            {
                //if state is found
                if (state.StateName.Equals(stateName, StringComparison.OrdinalIgnoreCase))
                {
                    stateFound = true;

                    Console.WriteLine("\nState Found");

                    //take district name
                    Console.Write("ENTER DISTRICT NAME: ");
                    string districtName = Console.ReadLine();

                    //check if district already exists
                    bool districtExists = false;

                    //loop to find district
                    foreach (District district in state.Districts)
                    {
                        //if district found 
                        if (district.DistrictName.Equals(districtName, StringComparison.OrdinalIgnoreCase))
                        {
                            districtExists = true;
                            break;
                        }
                    }
                    //if district found
                    if (districtExists)
                    {
                        Console.WriteLine("\nDistrict already present");
                    }
                    //if district is not found
                    else
                    {
                        state.Districts.Add(new District(districtName));
                        Console.WriteLine("\nDistrict added successfully");
                    }

                    break;
                }
            }
            //if state is not found
            if (!stateFound)
            {
                Console.WriteLine("\nState not found! Please add the state first.");
            }
        }


        //method to add student
        public void AddStudent()
        {
            if (states.Count == 0)
            {
                Console.WriteLine("\nNo states available. Add a state first.");
                return;
            }

            //take state
            Console.Write("\nENTER STATE NAME: ");
            string stateName = Console.ReadLine();

            //pointer for state
            State selectedState = null;

            //loop to find state
            foreach (State state in states)
            {
                //check if state matches
                if (state.StateName.Equals(stateName, StringComparison.OrdinalIgnoreCase))
                {
                    selectedState = state;
                    break;
                }
            }

            //if state not found
            if (selectedState == null)
            {
                Console.WriteLine("\nState not found. Please add the state first.");
                return;
            }

            //check if any district exists
            if (selectedState.Districts.Count == 0)
            {
                Console.WriteLine("\nNo districts found. Add a district first.");
                return;
            }

            //take district
            Console.Write("\nENTER DISTRICT NAME: ");
            string districtName = Console.ReadLine();

            //pointer for district
            District selectedDistrict = null;

            //loop to find district
            foreach (District district in selectedState.Districts)
            {
                if (district.DistrictName.Equals(districtName, StringComparison.OrdinalIgnoreCase))
                {
                    selectedDistrict = district;
                    break;
                }
            }
            
            //if district not found
            if (selectedDistrict == null)
            {
                Console.WriteLine("\nDistrict not found. Please add the district first.");
                return;
            }

            //take student name
            Console.Write("\nENTER STUDENT NAME: ");
            string studentName = Console.ReadLine();

            //take student score
            Console.Write("ENTER SCORE: ");
            int score = Convert.ToInt32(Console.ReadLine());

            //create object
            Student student = new Student(studentName, score, selectedDistrict.DistrictName,selectedState.StateName);

            //add student
            selectedDistrict.Students.Add(student);

            Console.WriteLine("Student Added Successfully");
        }


        //merge sort method
        public ArrayList MergeSort(ArrayList students)
        {
            if (students.Count <= 1)
            {
                return students;
            }

            int mid = students.Count / 2;

            ArrayList left = new ArrayList();
            ArrayList right = new ArrayList();
                
            for (int i = 0; i < mid; i++)
                left.Add(students[i]);
            for (int i = mid; i < students.Count; i++)
                right.Add(students[i]);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);

        }

        //method to merge sorted lists
        public ArrayList Merge(ArrayList left,ArrayList right)
        {
            ArrayList result = new ArrayList();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                Student sLeft = (Student)left[i];
                Student sRight = (Student)right[j];

                // Descending order
                if (sLeft.Score >= sRight.Score)
                {
                    result.Add(sLeft);
                    i++;
                }
                else
                {
                    result.Add(sRight);
                    j++;
                }
            }

            while (i < left.Count) result.Add(left[i++]);
            while (j < right.Count) result.Add(right[j++]);

            return result;
        }

        //display sorted results according to rank
        public void DisplayResult()
        {
            if (states.Count == 0)
            {
                Console.WriteLine("\nNo Details Exists");
                return;
            }

            //array list to store all srudents 
            ArrayList data = new ArrayList();

            //loop through states array list
            foreach(State state in states)
            {
                //loop through districts
                foreach(District district in state.Districts)
                {
                    //loop through students
                    foreach(Student student in district.Students)
                    {
                        data.Add(student);
                    }
                }
            }

            //call merge sort method
            data=MergeSort(data);
            int rank = 1;

            foreach(Student student in data)
            {
                Console.WriteLine(student);
                Console.WriteLine("Rank: "+rank++);
            }


        }

    }
}
