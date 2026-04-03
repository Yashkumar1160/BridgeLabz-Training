using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class EvenNumbers
    {
        //method to check if number is even
        public bool IsEven(int number)
        {
            //check remainder when divided by 2
            return number % 2 == 0;
        }
    }
}
