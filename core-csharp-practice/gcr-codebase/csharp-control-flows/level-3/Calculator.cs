using System;
class Calculator{
	static void Main(string[]args){
		//take two double inputs for variables first and second
		Console.WriteLine("Enter first number:");
		double first=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter second number:");
		double second=Convert.ToDouble(Console.ReadLine());
		
		//take string operator input
		Console.WriteLine("Enter operator:");
		string op=Console.ReadLine();
		
		//using switch case to perform operation
		switch(op){
			case "+":
				//if operator given is "+"
				Console.WriteLine("Result: "+(first+second));
				break;
			case "-":
				//if operator given is "-"
				Console.WriteLine("Result: "+(first-second));
				break;
			case "*":
				//if operator given is "*"
				Console.WriteLine("Result: "+(first*second));
				break;
			case "/":
				//if operator given is "/"
				Console.WriteLine("Result: "+(first/second));
				break;
			default:
				//if operator is invalid
				Console.WriteLine("Invalid Operator");
				break;
				
		}
		
	}
}
