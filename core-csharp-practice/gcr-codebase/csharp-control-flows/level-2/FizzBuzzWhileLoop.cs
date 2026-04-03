using System;
class FizzBuzzWhileLoop{
	static void Main(string[]args){
		//take number input
		Console.WriteLine("Enter a number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//check if number is positive
		if(number>0){
			int i=0;
			while(i<=number){
				if(i%3==0 && i%5==0){
					Console.WriteLine("FizzBuzz");
				}
				else if(i%3==0){
					//print Fizz if number is multiple of 3 
					Console.WriteLine("Fizz");
				}
				else if(i%5==0){
					//print Buzz if number is multiple of 5
					Console.WriteLine("Buzz");
				}
				else{
					Console.WriteLine(i);
				}
				i++;
			}
		}
		else{
			//if number is negative
			Console.WriteLine("Negative Number");
		}
		
	}
}