using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.resume_screening_system
{
    internal class Resume<T> where T : JobRole 
    {
        //array to store job role resumes
        T[] resumes = new T[100];

        //variable to store total resume count
        int totalResume = 0;

        //method to add resume
        public void AddResume(T resume)
        {
            resumes[totalResume++] = resume;
        }

        //method to process all resumes
        public void ProcessResumes()
        {
            for(int i = 0; i < totalResume; i++)
            {
                resumes[i].Evaluate();
            }
        }
    }
}
