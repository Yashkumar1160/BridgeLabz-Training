using System;
class NaturalNumberSum{
	static void Main(string[]args){
		//Take user input number
		Console.WriteLine("Enter Number:");
		int number=Convert.ToInt32(Console.ReadLine());
		//Check if number entered is a natural number
		if(number>0){
			//Sum of natural numbers using formulae
			int sum=number*(number+1)/2;
			Console.WriteLine("The sum of natural numbers using formulae is "+sum);
			
			//Sum of natural numbers using while loop
			int total=0;
			while(number>0){
				total+=number;//add number to total
				number--;//decrement number
			}
			Console.WriteLine("The sum of natural numbers using while loop is "+total);

			
		}
		//if number entered is not a natural number
		else{
			Console.WriteLine("The number is not a natural number");

		}
	}
	
}