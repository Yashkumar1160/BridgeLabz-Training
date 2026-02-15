using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.exceptions
{
    public class InvalidNumberException:Exception 
    {
        public InvalidNumberException(string message):base(message){ }   
        
    }
}