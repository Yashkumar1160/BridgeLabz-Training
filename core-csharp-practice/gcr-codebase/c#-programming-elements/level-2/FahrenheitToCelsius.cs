using System;
class FahrenheitToCelsius{
	static void Main(string[]args){
		//Reads fahrenheit input value
		double fahrenheit=Convert.ToDouble(Console.ReadLine());
		//Converting fahrenheit to celsius
		double celsius=(fahrenheit-32)*5/9;
		Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsius+" celsius");
	}
}