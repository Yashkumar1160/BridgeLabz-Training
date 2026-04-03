using System;
class LargestOfThree{
	static void Main(string[]args){
		//Reads the input values of three numbers
		Console.WriteLine("Enter number1:");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter number2:");
		int number2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter number3:");
		int number3=Convert.ToInt32(Console.ReadLine());
		
		//Checking if first number is the largest
		if(number1>number2&&number1>number3){
			Console.WriteLine("Is the first number the largest? Yes");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest? No");
		}
		//Checking if second number is the largest
		else if(number2>number1&&number2>number3){
			Console.WriteLine("Is the first number the largest? No");
			Console.WriteLine("Is the second number the largest? Yes");
			Console.WriteLine("Is the third number the largest? No");
		}
		//if both are not largest then the third number is the largest
		else{
			Console.WriteLine("Is the first number the largest? No");
			Console.WriteLine("Is the second number the largest? No");
			Console.WriteLine("Is the third number the largest? Yes");
		}
	}
}