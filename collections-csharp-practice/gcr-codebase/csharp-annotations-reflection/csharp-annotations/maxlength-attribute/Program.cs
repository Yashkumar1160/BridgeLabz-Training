using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.maxlength_attribute
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //valid username
            User user1 = new User("Yash123");
            user1.Display();

            //invalid username 
            User user2 = new User("VeryLongUsername");
        }
    }
}
