using System;
class AddDigits{
	static void Main(string[]args){
		//take integer input
		int num=Convert.ToInt32(Console.ReadLine());
		
		//repeat until number becomes a single digit
		while(num>=10){
			int sum=0;
			//add all the digits
			while(num!=0){
				int digit=num%10;
				sum+=digit;
				num/=10;
			}
			num=sum;
		}
		Console.WriteLine("Answer: "+num);
		
	}
}