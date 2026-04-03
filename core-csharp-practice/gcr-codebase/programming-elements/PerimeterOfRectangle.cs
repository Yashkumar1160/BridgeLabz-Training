using System;
class PerimeterOfRectangle{
	static void Main(string[]args){
		//Reads the length and width of rectangle
		double length=Convert.ToDouble(Console.ReadLine());
		double width=Convert.ToDouble(Console.ReadLine());
		//Calculating perimeter
		double perimeter=2*(length+width);
		Console.WriteLine("The perimeter of rectangle is: "+perimeter);
		
	}
}