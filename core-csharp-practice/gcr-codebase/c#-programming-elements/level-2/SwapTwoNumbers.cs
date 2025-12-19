using System;
class SwapTwoNumbers{
	static void Main(string[]args){
		//Reads number1 and number2 input values
		int number1=Convert.ToInt32(Console.ReadLine());
		int number2=Convert.ToInt32(Console.ReadLine());
		
		//Swapping both numbers
		int temp=number1;
		number1=number2;
		number2=temp;
		
		//Output
		Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
	}
}