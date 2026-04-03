using System;
class SimpleInterest{
	static void Main(string[]args){
		//Reads input for principal, rate and time
		double principal=Convert.ToDouble(Console.ReadLine());
		double rate=Convert.ToDouble(Console.ReadLine());
		double time=Convert.ToDouble(Console.ReadLine());
		
		//Calculating simple interest
		double simpleInterest=(principal*rate*time)/100;
		
		//Output
		Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal, "+principal+" Rate of Interest "+rate+" and Time "+time);
		
	}
}