using System;
class CheckFirstSmallest{
	static void Main(string[]args){
		//Read inputs for number1, number2 and number3
		Console.WriteLine("Enter number1:");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter number2:");
		int number2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter number3:");
		int number3=Convert.ToInt32(Console.ReadLine());
		
		//checking if the first number(number1) is the smallest
		if(number1<number2 && number1<number3){
			Console.WriteLine("Is the first number the smallest? YES");
		}
		else{
			Console.WriteLine("Is the first number the smallest? NO");
		}
	}
}