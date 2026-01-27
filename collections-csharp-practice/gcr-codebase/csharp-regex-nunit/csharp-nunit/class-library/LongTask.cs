using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{

    public class LongTask
    {
        //method that runs slowly
        public void LongRunningTask()
        {
            //pause program for 3 seconds
            Thread.Sleep(3000);
        }
    }
}
