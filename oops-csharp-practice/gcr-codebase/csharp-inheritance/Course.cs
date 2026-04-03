using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Course
    internal class Course
    {
        //protected variables
        protected string courseName;

        protected int duration;

        //parameterized constructor
        public Course(string courseName, int duration)
        {
            this.courseName = courseName;
            this.duration = duration;
        }

        //method to display course info 
        public virtual void DisplayInfo()
        {
            Console.WriteLine("COURSE NAME: " + courseName);
            Console.WriteLine("COURSE DURATION: " + duration);
        }
    }

    //derived class OnlineCourse
    class OnlineCourse : Course
    {
        //protected variables
        protected string platform;

        protected bool isRecorded;

        //parameterized constructor
        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            this.platform = platform;
            this.isRecorded = isRecorded;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            //call base class DisplayInfo method
            base.DisplayInfo();
         
            Console.WriteLine("PLATFORM :" + platform);
            
            Console.WriteLine("RECORDED: " + isRecorded);
        }
    }

    //derived class PaidOnlineCourse
    class PaidOnlineCourse : OnlineCourse
    {
        //private variables
        double fee;

        double discount;

        //parameterized constructor
        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
        {
            this.fee = fee;
            this.discount = discount;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            //call base class DisplayInfo method
            base.DisplayInfo();

            Console.WriteLine("FEE: " + fee);

            Console.WriteLine("DISCOUNT: " + discount);

            double finalFee = fee - (fee * discount / 100);

            Console.WriteLine("FINAL FEE: " + finalFee);
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //method to take user inputs
        public static void TakeInputs()
        {
            //take course name input
            Console.Write("ENTER COURSE NAME: ");
            string name = Console.ReadLine();

            //take duration input
            Console.Write("ENTER DURATION: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            //take platform input
            Console.Write("ENTER PLATFORM: ");
            string platform = Console.ReadLine();

            //take course recorded input
            Console.Write("IS COURSE RECORDED: ");
            bool isRecorded = Convert.ToBoolean(Console.ReadLine());

            //take course fee input
            Console.Write("ENTER COURSE FEE: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            //take discount input
            Console.Write("ENTER DISCOUNT: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            //create object of PaidOnlineCourse class
            Course course = new PaidOnlineCourse(name, duration, platform, isRecorded, fee, discount);

            //display course details using DisplayInfo method
            Console.WriteLine("\nCOURSE DETAILS: ");

            course.DisplayInfo();
        }
    }
}
