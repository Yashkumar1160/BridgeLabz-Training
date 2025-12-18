using System;
class PowerCalculation{
	static void Main(string[]args){
		//Reads the base and exponent values
		double baseValue=Convert.ToDouble(Console.ReadLine());
		double exponent=Convert.ToDouble(Console.ReadLine());
		
		//Calculating power 
		double answer=Math.Pow(baseValue,exponent);
		Console.WriteLine("Answer is :"+answer);
		
	}
}