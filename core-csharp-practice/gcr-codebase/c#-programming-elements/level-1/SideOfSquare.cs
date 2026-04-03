using System;
class SideOfSquare{
	static void Main(string[]args){
		//Reads perimeter of square
		double perimeter=Convert.ToDouble(Console.ReadLine());
		//Finding the side of square
		double side=perimeter/4;
		//Output
		Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter);
	}
}