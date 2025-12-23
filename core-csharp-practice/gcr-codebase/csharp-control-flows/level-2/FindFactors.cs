using System;
class FindFactors{
	static void Main(string[]args){
		//take input number
		Console.WriteLine("Enter a number");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//finding factors of number
		Console.WriteLine("Factors of "+number+" are :");
		for(int i=1;i<=number;i++){
			//check if number is divisible by i
			if(number%i==0){
				Console.WriteLine(i);
			}
		}
	}
}