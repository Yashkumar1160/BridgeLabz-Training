using System;
class ArmstrongNumber{
	static void Main(string[]args){
		//take input number
		Console.WriteLine("Enter Number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		//initialize sum variable to 0
		int sum=0;
		int originalNumber=number;
		
		//using while loop till the originalNumber!=0
		while(originalNumber!=0){
			int remainder=originalNumber%10;
			sum+=remainder*remainder*remainder;
			originalNumber=originalNumber/10;
		}
		
		//check if the number and sum are equal
		if(number==sum){
			Console.WriteLine("Armstrong Number");
		}
		else{
			Console.WriteLine("Not a Armstrong Number");
		}
	}
}