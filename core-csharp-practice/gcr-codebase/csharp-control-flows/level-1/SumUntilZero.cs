using System;
class SumUntilZero{
	static void Main(string[]args){
		//initialize total variable with 0.0
		double total=0.0;
		//Read the input value of first number
		Console.WriteLine("Enter number: ");
		double number=Convert.ToDouble(Console.ReadLine());
		
		//while loop continues till user enters 0
		while(number!=0){
			//add number to total 
			total+=number;
			
			//Take another number input
			Console.WriteLine("Enter number: ");
			number=Convert.ToDouble(Console.ReadLine());
		}
		//Output
		Console.WriteLine("Total is: "+total);
		
	}
}