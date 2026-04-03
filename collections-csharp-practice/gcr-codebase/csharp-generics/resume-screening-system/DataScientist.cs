using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.resume_screening_system
{
    internal class DataScientist : JobRole 
    {
        //constructor
        public DataScientist(string candidateName) : base(candidateName) { }

        //override Evaluate method
        public override void Evaluate()
        {
            Console.WriteLine(CandidateName + " evaluated for Data Scientist role");
        }
    }
}
