using System;
class AverageOfThreeeNumbers{
	static void Main(string[]args){
		//Reads three numbers 
		int num1=Convert.ToInt32(Console.ReadLine());
		int num2=Convert.ToInt32(Console.ReadLine());
		int num3=Convert.ToInt32(Console.ReadLine());
		//Calculating average
		double average=(num1+num2+num3)/3;
		Console.WriteLine("The average is :"+average);
		
	}
}