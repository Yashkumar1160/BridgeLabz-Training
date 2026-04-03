using System;
class KilometerToMiles{
		static void Main(string[]args){
			//Distance in kilometer 
			double distanceInKilometer=10.8;
			//Converting into miles
			double distanceInMiles=distanceInKilometer*0.625;
			//Output
			Console.WriteLine("The distance "+distanceInKilometer+"km in miles is "+distanceInMiles);
		}
}