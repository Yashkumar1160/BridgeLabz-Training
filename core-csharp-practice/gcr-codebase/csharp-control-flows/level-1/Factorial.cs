using System;
class Factorial{
	static void Main(string[]args){
		//take user input number
		Console.WriteLine("Enter number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//Check if the number is positive or not 
		if(number>=0){
			//Computing the factorial using while loop
			int factorial=1;
			while(number!=0){
				factorial=factorial*number;
				number--;
			}
			Console.WriteLine("The factorial is: "+factorial);
		}
		//if number is not positive
		else{
			Console.WriteLine("The number is not a positive.");
		}	
		
	}
	
}