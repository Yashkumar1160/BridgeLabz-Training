using System;
class VolumeOfEarth{
	static void Main(string[]args){
		//radius of earth in km
		double radiusKm=6378;
		//Calculating volume of earth in cubic kilometer
		double volumeInKilometer=(4.0/3.0)*3.14*radiusKm*radiusKm*radiusKm;
		//radius of earth in miles
		double radiusMiles=radiusKm*0.621371;
		//Calculating volumeof earth in cubic miles
		double volumeInMiles=(4.0/3.0)*3.14*radiusMiles*radiusMiles*radiusMiles;
		//Output
		Console.WriteLine("The volume of earth in cubic kilometers is "+volumeInKilometer+" and cubic miles is "+volumeInMiles);
	}
}