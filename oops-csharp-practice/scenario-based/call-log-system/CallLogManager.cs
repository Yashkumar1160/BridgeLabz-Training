using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_system
{
    internal class CallLogManager
    {
        //array to store call logs
        private CallLog[]callLogs=new CallLog[100];

        //variable to count call logs
        private int totalLogs = 0;

        //method to add a call log
        public void AddCallLog(CallLog log)
        {
            callLogs[totalLogs] = log;
            totalLogs++;
        }


        //method to search for a log with a keyword
        public void SearchByKeyword(string keyword)
        {
            for(int i = 0; i < totalLogs; i++)
            {
                //cast call log to ISearchable
                ISearchable searchable = callLogs[i] as ISearchable;

                if(searchable != null && searchable.ContainsKeyword(keyword))
                {
                    callLogs[i].DisplayLogDetails();
                }
            }
        }

        //method to filter call log by time
        public void FilterByTime(DateTime start, DateTime end)
        {
            Console.WriteLine("FILTERED BY TIME: ");

            for(int i = 0; i < totalLogs; i++)
            {
                DateTime time = callLogs[i].GetTimeStamp();

                if(time>=start && time <= end)
                {
                    callLogs[i].DisplayLogDetails();
                }
            }
        }

        //method to display all logs
        public void ViewAllLogs()
        {
            Console.WriteLine("CALL LOGS: ");

            for(int i = 0;i < totalLogs;i++)
            {
                callLogs[i].DisplayLogDetails();
            }
        }
    }
}
