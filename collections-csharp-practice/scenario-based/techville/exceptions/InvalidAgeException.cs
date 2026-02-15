using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.exceptions
{
    public class InvalidAgeException:Exception
    {
        public InvalidAgeException(string message):base(message){ }   
        
    }
}