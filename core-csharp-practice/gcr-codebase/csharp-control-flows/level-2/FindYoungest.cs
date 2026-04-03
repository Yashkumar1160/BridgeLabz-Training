using System;
class FindYoungest{
	static void Main(string[]args){
		//take age and height inputs from Amar, Akbar and Anthony
		Console.WriteLine("Enter Amar's age:");
		int amarAge=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Amar's height:");
		double amarHeight=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter Akbar's age:");
		int akbarAge=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Akbar's height:");
		double akbarHeight=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter Anthony's age:");
		int anthonyAge=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Anthony's height:");
		double anthonyHeight=Convert.ToDouble(Console.ReadLine());
		
		//finding youngest among three
		if(amarAge<=akbarAge && amarAge<=anthonyAge){
			Console.WriteLine("Amar is youngest");
		}
		else if(akbarAge<=amarAge && akbarAge<=anthonyAge){
			Console.WriteLine("Akbar is youngest");
		}
		else{
			Console.WriteLine("Anthony is youngest");
		}
		
		//finding tallest
		if(amarHeight>=akbarHeight &&amarHeight>=anthonyHeight){
			Console.WriteLine("Amar is tallest");
		}
		else if(akbarHeight>=amarHeight && akbarHeight>=anthonyHeight){
			Console.WriteLine("Akbar is tallest");
		}
		else{
			Console.WriteLine("Anthony is tallest");
		}
		
		
	}
}