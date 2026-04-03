using System;
class FactorialWithForLoop{
	static void Main(string[]args){
		//take user input number
		Console.WriteLine("Enter number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//check if number entered is positive or not
		if(number>=0){
			//finding factorial using for loop
			int factorial=1;
			for(int i=1;i<=number;i++){
				factorial=factorial*i;
			}
			Console.WriteLine("The factorial is :"+factorial);
		}
		else{
			//if number is not positive or less than 0
			Console.WriteLine("The number is less than 0");
			
		}
	}
}