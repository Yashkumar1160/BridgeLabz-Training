using System;
class AreaOfTriangle{
	static void Main(string[]args){
		//Reads base and height values in cm
		double baseCm=Convert.ToDouble(Console.ReadLine());
		double heightCm=Convert.ToDouble(Console.ReadLine());
		
		//Converting cm to inches
		double baseInches=baseCm/2.54;
		double heightInches=heightCm/2.54;
		
		//Calculating area in square inches and square centimeter
		double areaInSqInches=0.5*baseInches*heightInches;
		double areaInSqCm=0.5*baseCm*heightCm;
		//Output
		Console.WriteLine("The area of triangle is square inches is "+areaInSqInches+" and in square centimeters is "+areaInSqCm);
	}
}