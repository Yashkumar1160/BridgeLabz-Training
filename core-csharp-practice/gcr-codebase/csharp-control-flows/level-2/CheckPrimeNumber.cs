using System;
class CheckPrimeNumber{
	static void Main(string[]args){
		//take user input number
		Console.WriteLine("Enter a number:");
		int number=Convert.ToInt32(Console.ReadLine());
		//initialize isPrime with true
		bool isPrime=true;
		if(number<=1){
			//check if number is less than or equal to 1
			isPrime=false;
		}
		else{
			//checking if the number is a prime number or not 
			for(int i=2;i<number;i++){
				if(number%i==0){
					isPrime=false;
					break;
				}
			}
		}
		if(isPrime){
			Console.WriteLine("Prime number");
		}
		else{
			Console.WriteLine("Not a prime number");
		}
	}
}