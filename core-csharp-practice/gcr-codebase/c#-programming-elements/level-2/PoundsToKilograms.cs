using System;
class PoundsToKilograms{
	static void Main(string[]args){
		//Reads pounds input value
		double pounds=Convert.ToDouble(Console.ReadLine());
		
		//Converting pounds to kg
		double kilogram=pounds/2.2;
		
		//Output
		Console.WriteLine("The weight of the person in pounds is "+pounds+" and in kg is "+kilogram);
	}
}