using System;
class SumOfNaturalNumber{
	static void Main(string[]args){
		//Reads input value
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//Checking if the number entered is a natural number
		if(number>0){
			//Calculating sum of natural numbers
			int sum=number*(number+1)/2;
			Console.WriteLine("The sum of "+number+" natural number is "+sum);
		}
		//if number entered  is not a natural number
		else{
			Console.WriteLine("The number "+number+" is not a natural number");
		}
		
	}
}