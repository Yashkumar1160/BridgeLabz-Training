using System;
class HarshadNumber{
	static void Main(string[]args){
		//take number input
		Console.WriteLine("Enter a number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		//store original number
		int originalNumber=number;
		
		//initialize sum variable with 0
		int sum=0;
		
		//loop to access each digit
		while(number!=0){
			int digit=number%10;
			sum+=digit;
			number=number/10;
		}
		//check if original number is divisible by sum
		if(originalNumber%sum==0){
			Console.WriteLine("Harshad Number");
		}else{
			Console.WriteLine("Not a Harshad Number");
		}
	}
}