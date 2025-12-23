using System;
class FizzBuzz{
	static void Main(string[]args){
		//take number input 
		Console.WriteLine("Enter a number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//check if number is positive 
		if(number>0){
			for(int i=0;i<=number;i++){
				//print FizzBuzz if number is multiple of both 3 and 5
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
			}
		}
		else{
			Console.WriteLine("Number is negative");
		}
	}
}