using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.healthcare_exceptions
{
    public class HealthcareExceptions:Exception
    {
        public HealthcareExceptions(string message) : base(message)
        {
            
        }
    }
}