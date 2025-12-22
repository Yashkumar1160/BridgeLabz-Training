using System;
class Armstrong{
	static void Main(string[]args){
		//take integer input
		int number=Convert.ToInt32(Console.ReadLine());
		//store original number
		int original=number;
		int sum=0;
		//loop until for all digits
		while(number!=0){
			int digit=number%10;
			sum+=digit*digit*digit;
			number/=10;
		}
		Console.WriteLine(sum==original);
	}
}