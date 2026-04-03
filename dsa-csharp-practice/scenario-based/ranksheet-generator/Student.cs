using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.ranksheet_generator
{
    internal class Student
    {
        //attributes
        string studentName;
        int score;
        string districtName;
        string stateName;

        //getters and setters
        public String StudentName { get; set; }
        public int Score { get; set; }
        public string DistrictName { get; set; }
        public string StateName { get; set; }


        //constructor
        public Student(string studentName,int score,string districtName,string stateName)
        {
            StudentName = studentName;
            Score = score;
            DistrictName = districtName;
            StateName = stateName;
        }

        //override ToString method
        public override string ToString()
        {
            return "\nStudent Name: " + StudentName +
                "\nScore: " + Score+
                "\nDistrict: "+DistrictName+
                "\nState: "+StateName;
        }
    }
}
