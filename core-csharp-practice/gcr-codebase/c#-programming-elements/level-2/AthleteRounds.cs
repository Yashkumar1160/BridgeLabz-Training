using System;
class AthleteRounds{
	static void Main(string[]args){
		//Reads triangle sides values
		double side1=Convert.ToDouble(Console.ReadLine());
		double side2=Convert.ToDouble(Console.ReadLine());
		double side3=Convert.ToDouble(Console.ReadLine());
		//Calculating perimeter of triangle
		double perimeter=side1+side2+side3;
		//Calculating total rounds
		double rounds=5000/perimeter;
		
		Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km");
		
		
	}
}