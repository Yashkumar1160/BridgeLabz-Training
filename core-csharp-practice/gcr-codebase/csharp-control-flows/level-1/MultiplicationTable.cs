using System;
class MultiplicationTable{
	static void Main(string[]args){
		//take user input number
		Console.WriteLine("Enter Number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//using for loop from 6 to 9 to print multiplication table
		for(int i=6;i<=9;i++){
			Console.WriteLine(number+" * "+i+" = "+(number*i));
		}
		
	}
}