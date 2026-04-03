using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    internal class InpatientImpl : Patient, IPayable
    {
        //variable to store number of days
        int days;

        //variable to store room charge per day
        double roomCharge;

        //parameterized constructor
       public InpatientImpl(string patientId, string name, int age,int days, double charge) : base(patientId, name, age)
       {
            this.days = days;
            this.roomCharge = charge;
       }
                
        //implementation of CalculateBill method
        public double CalculateBill()
        {
            return days*roomCharge;
        }

        //method to display patient details
        public override void DisplayPatientInfo()
        {
            Console.WriteLine("\nINPATIENT");
            
            Console.WriteLine("PATIENT ID: "+GetPatientId());
            
            Console.WriteLine("NUMBER OF DAYS: "+days);
            
            Console.WriteLine("CHARGE PER DAY: "+roomCharge);
            
            Console.WriteLine("TOTAL BILL: "+CalculateBill());
        }
    }
}
