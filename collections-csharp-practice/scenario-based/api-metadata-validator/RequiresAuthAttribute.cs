using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.api_metadata_validator
{
    //marks APIs that need authentication
    [AttributeUsage(AttributeTargets.Method)]
    internal class RequiresAuthAttribute : Attribute
    {
    }
}
