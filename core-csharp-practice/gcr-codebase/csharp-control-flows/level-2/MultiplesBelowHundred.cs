using System;
class MultiplesBelowHundred{
	static void Main(string[]args){
		//take input number
		Console.WriteLine("Enter a number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//finding multiples of number below 100
		Console.WriteLine("Multiples of number below 100 are:");
		for(int i=100;i>=1;i--){
			//check if i is a multiple of number
			if(i%number==0){
				Console.WriteLine(i);
			}
		}
	}
}