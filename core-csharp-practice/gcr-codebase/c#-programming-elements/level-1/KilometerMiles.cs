using System;
class KilometerMiles{
	static void Main(string[]args){
		//Reads kilometer value
		double kilometer=Convert.ToDouble(Console.ReadLine());
		//Converting km to miles
		double miles=kilometer*0.625;
		//Output
		Console.WriteLine("The total miles is "+miles+" mile for the given "+kilometer+" km");	
	}
}