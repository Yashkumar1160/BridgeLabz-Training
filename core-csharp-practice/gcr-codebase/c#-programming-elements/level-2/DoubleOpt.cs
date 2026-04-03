using System;
class DoubleOpt{
	static void Main(string[]args){
		//Reads double values for a, b and c
		double a=Convert.ToDouble(Console.ReadLine());
		double b=Convert.ToDouble(Console.ReadLine());
		double c=Convert.ToDouble(Console.ReadLine());
		
		//Performing double operations
		double firstOperation=a+b*c;
		double secondOperation=a*b+c;
		double thirdOperation=c+a/b;
		double fourthOperation=a%b+c;
		
		Console.WriteLine("The results of Double Operations are "+firstOperation+", "+secondOperation+", "+thirdOperation+" and "+fourthOperation);
		
		
	}
}