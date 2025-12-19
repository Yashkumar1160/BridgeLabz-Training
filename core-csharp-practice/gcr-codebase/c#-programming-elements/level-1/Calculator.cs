using System;
class Calculator{
	static void Main(string[]args){
		//Reads float values for num1 and num2
		float num1=float.Parse(Console.ReadLine());
		float num2=float.Parse(Console.ReadLine());
		
		//Addition
		float addition=num1+num2;
		
		//Subtraction
		float subtraction=num1-num2;
		
		//Multiplication
		float multiplication=num1*num2;
		
		//Division
		float division=num1/num2;
		
		//Output
		Console.WriteLine("The addition, subtraction, multiplication and division of 2 numbers "+num1+" and "+num2+" is "+addition+" "+subtraction+" "+multiplication+" "+division);
		
		
	}
}