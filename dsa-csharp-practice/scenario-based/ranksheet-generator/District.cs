using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.ranksheet_generator
{
    internal class District
    {
        //attributes
        string districtName;
        ArrayList students;

        //getter and setter
        public string DistrictName { get; set; }
        public ArrayList Students{ get; set; }

        
        //constructor
        public District(string districtName)
        {
            DistrictName = districtName;
            Students = new ArrayList();
        }
    }
}
