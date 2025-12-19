using System;
class ChocolateDivision{
	static void Main(string[]args){
		//Reads number of chocolates and number of children
		int numberOfChocolates=Convert.ToInt32(Console.ReadLine());
		int numberOfChildren=Convert.ToInt32(Console.ReadLine());
		
		//Finding distributed chocolates and remaining chocolates
		int eachGets=numberOfChocolates/numberOfChildren;
		int remaining=numberOfChocolates%numberOfChildren;
		
		Console.WriteLine("The number of chocolates each child gets is "+eachGets+" and the number of remaining chocolates is "+remaining);
	}
}