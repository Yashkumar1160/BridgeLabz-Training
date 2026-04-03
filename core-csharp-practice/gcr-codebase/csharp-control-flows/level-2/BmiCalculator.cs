using System;
class BmiCalculator{
	static void Main(string[]args){
		//take user input for weight and height
		Console.WriteLine("Enter weight in kg:");
		double weightKg=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter height in cm:");
		double heightCm=Convert.ToDouble(Console.ReadLine());
		
		//converting cm to meter
		double heightMeter=heightCm/100;
		
		//calculating BMI 
		double bmi=weightKg/(heightMeter*heightMeter);
		Console.WriteLine("BMI: "+bmi);
		
		//determining weight of person
		if(bmi<=18.5){
			Console.WriteLine("Underweight");
		}
		else if(bmi>18.5 && bmi<=24.9){
			Console.WriteLine("Normal");
		}
		else if(bmi>=25 && bmi<=39.9){
			Console.WriteLine("Overweight");
		}
		else{
			Console.WriteLine("Obese");
		}
		
		
	}
}