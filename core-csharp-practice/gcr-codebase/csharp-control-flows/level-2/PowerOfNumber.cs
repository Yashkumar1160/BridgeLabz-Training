using System;
class PowerOfNumber{
	static void Main(string[]args){
		//take input number and power
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter power:");
		int power=Convert.ToInt32(Console.ReadLine());
		//initialize result with 1
		int result=1;
		
		//using for loop from 1 to power
		for(int i=1;i<=power;i++){
			result=result*number;
		}
		
		Console.WriteLine("Result :"+result);
		
	}
}