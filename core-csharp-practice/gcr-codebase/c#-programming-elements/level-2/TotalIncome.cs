using System;
class TotalIncome{
	static void Main(string[]args){
		//Reads salary and bonus values
		double salary=Convert.ToDouble(Console.ReadLine());
		double bonus=Convert.ToDouble(Console.ReadLine());
		
		//Finding income
		double totalIncome=salary+bonus;
		
		//Output
		Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence the Total Income is INR "+totalIncome);
		
	}
}