using System;
class TemperatureConversion{
	static void Main(string[]args){
		//Reads celsius input value
		double celsius=Convert.ToDouble(Console.ReadLine());
		//Converting celsius to fahrenheit
		double fahrenheit=(celsius*9/5)+32;
		//Output
		Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");
	}
}