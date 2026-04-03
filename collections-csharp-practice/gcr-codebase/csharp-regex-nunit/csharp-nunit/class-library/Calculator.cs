namespace class_library
{
    public class Calculator
    {
        //method to add two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        //method to subtract two numbers
        public int Subtract(int a, int b)
        {
            return a - b;
        }
            
        //method to multiply two numbers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        //method to divide two numbers
        public int Divide(int a, int b)
        {
            //if second number is zero
            if (b == 0)
            {
                //throw divide by zero exception
                throw new DivideByZeroException();
            }

            //return division result
            return a / b;
        }
    }
}
