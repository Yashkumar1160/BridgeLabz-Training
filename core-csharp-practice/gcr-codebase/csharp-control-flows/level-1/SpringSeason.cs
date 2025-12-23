using System;
class SpringSeason{
	static void Main(string[]args){
		//Reads two integer values for month and day
		Console.WriteLine("Enter Month: ");
		int month=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Day: ");
		int day=Convert.ToInt32(Console.ReadLine());
		
		//Checking is the month and day is between the spring season
		if((month==3 && day>=20)||(month==4)||(month==5)||(month==6 && day<=20)){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}