using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.todo_attribute
{
    internal class Project
    {
        //todo for login feature
        [Todo("Add validation", "Yash")]
        [Todo("Improve UI", "abcd", "HIGH")]
        public void Login()
        {
            Console.WriteLine("Login feature");
        }

        //todo for report feature
        [Todo("Optimize query", "efgh")]
        public void GenerateReport()
        {
            Console.WriteLine("Report generated");
        }
    }
}
