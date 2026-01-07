using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_system
{
    internal abstract class CallLog
    {
        //variable to store phone number
        protected string phoneNumber;
        
        //variable to store message
        protected string message;

        //variable to store time stamp
        protected DateTime timeStamp;

        //parameterized constructor
        public CallLog(string phoneNumber, string message, DateTime timeStamp)
        {
            this.phoneNumber = phoneNumber;
            this.message = message;
            this.timeStamp = timeStamp;
        }

        //method to get time stamp
        public DateTime GetTimeStamp()
        {
            return timeStamp; 
        }

        //abstract method to display details of call log
        public abstract void DisplayLogDetails();
    }
}
