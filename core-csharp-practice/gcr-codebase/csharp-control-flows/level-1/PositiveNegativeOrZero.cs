using System;
class PositiveNegativeOrZero{
	static void Main(string[]args){
		//Reads input value of a number
		Console.WriteLine("Enter Number:");
		int number=Convert.ToInt32(Console.ReadLine());
		//Checking if the number is positive, negative or zero
		if(number>0){
			Console.WriteLine("Positive");
		}
		else if(number<0){
			Console.WriteLine("Negative");
		}
		else{
			Console.WriteLine("Zero");
		}
	}
}