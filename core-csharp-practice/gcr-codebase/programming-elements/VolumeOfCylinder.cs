using System;
class VolumeOfCylinder{
	static void Main(string[]args){
		//Reads the radius and height of cylinder
		double radius=Convert.ToDouble(Console.ReadLine());
		double height=Convert.ToDouble(Console.ReadLine());
		//Calculating the volume of cylinder
		double volume=3.14*radius*radius*height;
		Console.WriteLine("The volume of cylinder is: "+volume);
		
		
	}
}
