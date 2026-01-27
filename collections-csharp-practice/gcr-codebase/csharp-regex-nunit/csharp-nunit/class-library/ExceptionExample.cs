using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class ExceptionExample
    {
        //method to divide two numbers
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                //throw exception if denominator is zero
                throw new ArithmeticException("Cannot divide by zero");
            }
            return a / b;
        }
    }
}
