using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.resume_screening_system
{
    internal class ResumeMain
    {
        public static void Main(string[] args)
        {
            //create resume processors
            Resume<SoftwareEngineer> softwareResumes = new Resume<SoftwareEngineer>();
            Resume<DataScientist> dataResumes = new Resume<DataScientist>();

            //add resumes
            softwareResumes.AddResume(new SoftwareEngineer("Yash"));
            softwareResumes.AddResume(new SoftwareEngineer("Harsh"));

            dataResumes.AddResume(new DataScientist("Rahul"));
            dataResumes.AddResume(new DataScientist("Prashant"));

            //call ScreenResume method
            ResumeUtility.ScreenResume(new SoftwareEngineer("Karan"));

            //process all resumes
            Console.WriteLine("\nSOFTWARE ENGINEER RESUMES:");
            softwareResumes.ProcessResumes();

            Console.WriteLine("\nDATA SCIENTIST RESUMES:");
            dataResumes.ProcessResumes();
        }
    }
}
