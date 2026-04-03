using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.mark_important_methods
{
    internal class Service
    {
        //important method with default level
        [ImportantMethod]
        public void SaveData()
        {
            Console.WriteLine("Data saved");
        }

        //important method with custom level
        [ImportantMethod("LOW")]
        public void LoadData()
        {
            Console.WriteLine("Data loaded");
        }
    }
}
