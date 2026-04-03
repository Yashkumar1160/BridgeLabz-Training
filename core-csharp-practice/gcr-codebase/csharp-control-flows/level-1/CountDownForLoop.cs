using System;
class CountDownForLoop{
	static void Main(string[]args){
		//Reads input value for counter
		Console.WriteLine("Enter Counter:");
		int counter=Convert.ToInt32(Console.ReadLine());
		//for loop to count down till 1
		for(int i=counter;i>0;i--){
			Console.WriteLine(i);
		}
	}
}