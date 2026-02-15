using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.exceptions
{
    public class DuplicateCitizenException:Exception
    {
        public DuplicateCitizenException(string message):base(message){ }   
        
    }
}