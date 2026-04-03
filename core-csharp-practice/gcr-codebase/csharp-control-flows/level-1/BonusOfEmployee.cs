using System;
class BonusOfEmployee{
	static void Main(string[]args){
		//Reads employee salary and years of service
		Console.WriteLine("Enter salary:");
		double salary=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter years of service:");
		int yearsOfService=Convert.ToInt32(Console.ReadLine());
		
		//checking if years of service is greater than 5
		if(yearsOfService>5){
			//finding 5% bonus
			double bonus=salary*(5.0/100.0);
			
			Console.WriteLine("Bonus is :"+bonus);
			
		}else{
			//if years of service is less than 5 
			Console.WriteLine("No Bonus");
		}
	}
}