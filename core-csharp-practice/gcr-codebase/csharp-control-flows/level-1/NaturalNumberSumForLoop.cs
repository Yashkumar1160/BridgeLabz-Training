using System;
class NaturalNumberSumForLoop{
	static void Main(string[]args){
		//take user input number
		Console.WriteLine("Enter Number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//Checking if the number entered is a natural number
		if(number>0){
			//Finding sum of natural numbers using formulae
			int total=number*(number+1)/2;
			Console.WriteLine("The sum of natural numbers using formulae is "+total);
			
			
			//Finding sum of natural numbers using for loop
			int sum=0;
			for(int i=0;i<=number;i++){
				sum+=i;//add number to sum
			}
			Console.WriteLine("The sum of natural numbers using for loop is "+sum);
		}
		else{
			Console.WriteLine("The number "+number+" is not a natural number");
		}
	}
}