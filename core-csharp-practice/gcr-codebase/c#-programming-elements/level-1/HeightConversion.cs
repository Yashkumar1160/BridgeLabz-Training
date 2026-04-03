using System;
class HeightConversion{
	static void Main(string[]args){
		//Reads height value in centimeter
		double heightCm=Convert.ToDouble(Console.ReadLine());
		
		//Converting centimeter values to inches and feet
		double heightInches=heightCm/2.54;
		double heightFeet=heightInches/12;
		//Output
		Console.WriteLine("Your Height in cm is "+heightCm+" while in feet is "+heightFeet+" and inches is "+heightInches);
	}
}