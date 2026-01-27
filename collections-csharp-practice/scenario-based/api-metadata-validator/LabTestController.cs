using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.api_metadata_validator
{
    internal class LabTestController
    {
        //this method is public and does not need authentication
        [PublicApi]
        public void GetAllLabTests()
        {
            Console.WriteLine("Fetching all lab tests");
        }

        //this method is public but needs authentication
        [PublicApi]
        [RequiresAuth]
        public void BookLabTest()
        {
            Console.WriteLine("Booking a lab test");
        }

        //this method has no attributes (used to detect missing annotations)
        public void InternalMethod()
        {
            Console.WriteLine("Internal use only");
        }
    }
}
