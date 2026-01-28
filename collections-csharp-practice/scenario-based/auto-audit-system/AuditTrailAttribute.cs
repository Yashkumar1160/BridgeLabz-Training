using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.auto_audit_system
{
    //marks methods that should be audited
    [AttributeUsage(AttributeTargets.Method)]
    internal class AuditTrailAttribute : Attribute
    {
        //store action name
        public string ActionName { get; }

        //constructor
        public AuditTrailAttribute(string actionName)
        {
            ActionName = actionName;
        }
    }
}
