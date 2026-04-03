using System;
class CountDigits{
	static void Main(string[]args){
		//take number input
		Console.WriteLine("Enter Number:");
		int number=Convert.ToInt32(Console.ReadLine());
		//initialize count variable with 0
		int count=0;
		
		//loop until number!=0
		while(number!=0){
			number=number/10;
			count++;
		}
		
		Console.WriteLine("Number of digits: "+count);
	}
}