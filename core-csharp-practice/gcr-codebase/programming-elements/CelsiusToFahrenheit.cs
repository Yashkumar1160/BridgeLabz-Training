using System;
class CelsiusToFahrenheit{
	static void Main(string[]args){
		//Reads celsius value
		double celsius=Convert.ToDouble(Console.ReadLine());
		//Converting celsius to fahrenheit
		double fahrenheit=(celsius*9/5)+32;
		Console.WriteLine("Celsius: "+celsius+" Fahrenheit: "+fahrenheit);
	}
}