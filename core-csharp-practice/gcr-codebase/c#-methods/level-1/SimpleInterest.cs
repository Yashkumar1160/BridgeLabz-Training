using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class SimpleInterest
    {
        public static void Main(string[] args)
        {
            //take user inputs for variables principal, rate and time
            Console.WriteLine("Enter principal amount");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time ");
            double time = Convert.ToDouble(Console.ReadLine());

            //create instance of class
            SimpleInterest si = new SimpleInterest();
            //call method CalculateSimpleInterest()
            double simpleInterest = si.CalculateSimpleInterest(principal, rate, time);
            Console.WriteLine("The Simple Interest is " + simpleInterest);

        }
        //Method to find simple interest
        public double CalculateSimpleInterest(double principal, double rate, double time)
        {
            //calculate simple interest
            double simpleInterest = (principal * rate * time) / 100;
            //return simple interest
            return simpleInterest;
        }
    }
}
