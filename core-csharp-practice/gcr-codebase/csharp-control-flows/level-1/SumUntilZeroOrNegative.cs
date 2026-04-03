using System;
class SumUntilZeroOrNegative{
	static void Main(string[]args){
		//initialize total variable with 0.0;
		double total=0.0;
		
		//Infinite while loop
		while(true){
			//take user input values
			Console.WriteLine("Enter Number: ");
			double number=Convert.ToDouble(Console.ReadLine());
			
			//Check if number is negative or zero
			if(number<=0){
				break;
			}
			//if number is not equal to 0 and positive then add to total
			else{
				total+=number;
			}
		}
		Console.WriteLine("Total is :"+total);
	}
}