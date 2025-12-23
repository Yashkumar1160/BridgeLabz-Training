using System;
class OddEven{
	static void Main(string[]args){
		//take user input number
		Console.WriteLine("Enter number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//check if number entered is a natural number
		if(number>0){
			//iterating from 1 to number using for loop
			for(int i=1;i<=number;i++){
				//check if number is odd or even
				if(i%2==0){
					//if even
					Console.WriteLine(i+" is Even number.");
				}else{
					//if odd
					Console.WriteLine(i+" is Odd number.");
				}
			}
			
		}
	}
		
}