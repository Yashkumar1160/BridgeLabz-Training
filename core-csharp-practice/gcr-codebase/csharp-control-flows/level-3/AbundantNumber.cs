using System;
class AbundantNumber{
	static void Main(string[]args){
		//take integer input
		Console.WriteLine("Enter Number:");
		int number=Convert.ToInt32(Console.ReadLine());
		//initialize sum variable to 0
		int sum=0;
		
		//loop from 1 to number
		for(int i=1;i<number;i++){
			if(number%i==0){
				//if number is divisible by i then add it to sum
				sum+=i;
			}
		}
		//check if sum is greater than number 
		if(sum>number){
			Console.WriteLine("Abundant Number");
		}
		else{
			Console.WriteLine("Not a Abundant Number");
		}
	}
}