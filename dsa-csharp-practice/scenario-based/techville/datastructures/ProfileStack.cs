using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

namespace techville.datastructures
{
   //M-11 Stack for Undo Functionality
    public class ProfileStack
    {
        private Citizen[] stack = new Citizen[10];
        private int top = -1;

        //Push
        public void Push(Citizen citizen)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            stack[++top] = citizen;
        }

        //Pop
        public Citizen Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Nothing to Undo");
                return null;
            }

            return stack[top--];
        }
    }
}