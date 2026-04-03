using System;
class DivisibleByFive{
	static void Main(string[]args){
		//Reads number input
		Console.WriteLine("Enter a number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		//checking if number is divisible by 5
		if(number%5==0){
			Console.WriteLine("Is the number "+number+" divisible by 5? Yes");
		}
		//if number is not divisible by 5
		else{
			Console.WriteLine("Is the number "+number+" divisible by 5? No");
		}
	}
}