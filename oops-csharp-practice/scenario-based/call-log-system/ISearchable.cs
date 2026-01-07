using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_system
{
    internal interface ISearchable
    {
        //method check if keyword is present
        bool ContainsKeyword(string keyword);
    }
}
