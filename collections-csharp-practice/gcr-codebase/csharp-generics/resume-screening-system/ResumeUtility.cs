using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.resume_screening_system
{
    internal class ResumeUtility
    {
        //generic method to screen a resume
        public static void ScreenResume<T>(T resume) where T : JobRole
        {
            Console.WriteLine("Screening resume");
            resume.Evaluate();
        }
    }
}
