using System;
class LeapYear{
	static void Main(string[]args){
		//read year input
		Console.WriteLine("Enter Year:");
		int year=Convert.ToInt32(Console.ReadLine());
		
		//checking if year is a leap year or not using single if
		if(year>=1582 && (year%400==0||(year%4==0 && year%100 !=0))){
			Console.WriteLine("Year "+year+" is a leap year");
		}
		else{
			Console.WriteLine("Year "+year+" is not a leap year");
		}
	}
}