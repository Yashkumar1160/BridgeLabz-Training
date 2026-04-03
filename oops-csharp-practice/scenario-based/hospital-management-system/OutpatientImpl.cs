using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    internal class OutpatientImpl : Patient, IPayable 
    {
        //variable to store consultation fee
        double consultantFee;

        //parameterized constructor
        public OutpatientImpl(string patientId, string name, int age, double fee) : base(patientId, name, age)
        {
            this.consultantFee = fee;
        }

        //implementation od CalculateBill method 
        public double CalculateBill()
        {
            return consultantFee; 
        }

        //override DisplayPatientInfo method
        public override void DisplayPatientInfo()
        {
            Console.WriteLine("\nOUTPATIENT DETAILS");

            Console.WriteLine("PATIENT ID: " + GetPatientId());
            
            Console.WriteLine("TOTAL BILL: "+CalculateBill());
        }
    }
}
