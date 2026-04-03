using System;
class SimpleInterest{
	static void Main(string[]args){
		//Reads principal, rate and time values
		double principal=Convert.ToDouble(Console.ReadLine());
		double rate=Convert.ToDouble(Console.ReadLine());
		double time=Convert.ToDouble(Console.ReadLine());
		//Calculating simple interest 
		double simpleInterest=(principal*rate*time)/100;
		Console.WriteLine("The simple interest is: "+simpleInterest);
	}
}