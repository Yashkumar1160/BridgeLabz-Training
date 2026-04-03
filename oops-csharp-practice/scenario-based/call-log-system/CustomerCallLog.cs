using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_system
{
    internal class CustomerCallLog : CallLog, ISearchable 
    {
        //parameterized constructor
        public CustomerCallLog(string phoneNumber, string message, DateTime timeStamp) : base(phoneNumber, message, timeStamp) { }

        //implementation of ContainsKeyword method
        public bool ContainsKeyword(string keyword)
        {
            return message.Contains(keyword);
        }

        //method to display log details
        public override void DisplayLogDetails()
        {
            Console.WriteLine("\nPHONE NUMBER: "+phoneNumber);

            Console.WriteLine("MESSAGE: "+message);

            Console.WriteLine("TIME: "+timeStamp);

        }

    }
}
