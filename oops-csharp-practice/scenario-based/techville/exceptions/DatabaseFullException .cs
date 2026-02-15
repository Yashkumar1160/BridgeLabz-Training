using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.exceptions
{
    //M-5 Robust Registration System
    public class DatabaseFullException:Exception
    {
        public DatabaseFullException(string message):base(message){ }   
    }
}