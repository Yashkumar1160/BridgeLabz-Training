using System;
class CheckLeapYear{
	static void Main(string[]args){
		//take year input 
		Console.WriteLine("Enter Year:");
		int year=Convert.ToInt32(Console.ReadLine());
		
		//Check year based on Gregorian calendar
		if(year<1582){
			Console.WriteLine("Year must be 1582 or greater");
		}
		//check if year is a leap year
		else{
			if(year%400==0){
				Console.WriteLine("Year "+year+" is a leap year");
			}
			else if(year%100==0){
				Console.WriteLine("Year "+year+" is not a leap year");
			}
			else if(year%4==0){
				Console.WriteLine("Year "+year+" is a leap year");
			}
			else{
				Console.WriteLine("Year "+year+" is not a leap year");
			}
		}
	}
}