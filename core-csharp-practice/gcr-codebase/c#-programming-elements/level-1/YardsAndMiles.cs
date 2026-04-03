using System;
class YardsAndMiles{
	static void Main(string[]args){
		//Reads distance in feet
		double distanceInFeet=Convert.ToDouble(Console.ReadLine());
		
		//Finding distance in yards and in miles
		double distanceInYards=distanceInFeet/3;
		double distanceInMiles=distanceInYards/1760;
		
		//Output
		Console.WriteLine("The distance in yards is "+distanceInYards+" and in miles is "+distanceInMiles);
	}
}