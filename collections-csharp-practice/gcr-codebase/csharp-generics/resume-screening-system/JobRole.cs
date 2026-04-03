using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.resume_screening_system
{
    internal abstract class JobRole
    {
        //variable to store candidate name
        string candidateName;

        //getter and setter
        public string CandidateName { get; set; }

        //constructor
        public JobRole(string candidateName)
        {
            CandidateName = candidateName;
        }

        //abstract method to evaluate resume
        public abstract void Evaluate();
    }
}
