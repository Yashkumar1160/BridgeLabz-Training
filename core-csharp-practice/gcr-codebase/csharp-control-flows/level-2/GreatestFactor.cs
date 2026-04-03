using System;
class GreatestFactor{
	static void Main(string[]args){
		//take number input
		Console.WriteLine("Enter a number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		int greatestFactor=1;
		
		//using for loop from last to 1
		for(int i=number-1;i>=1;i--){
			//check if number is perfectly divisible by i
			if(number%i==0){
				greatestFactor=i;//assign i to greatestFactor
				break;
			}
		}
		Console.WriteLine("Greatest Factor "+greatestFactor);
	}
}