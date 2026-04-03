using System;
class AreaOfCircle{
	static void Main(string[]args){
		//Reads the value of radius
		double radius=Convert.ToDouble(Console.ReadLine());
		//Calculating the area of circle
		double area=3.14*radius*radius;
		Console.WriteLine("The area of circle is :"+area);
	}
}