using System;
class RocketLaunch{
	static void Main(string[]args){
		//Reads input value for counter
		Console.WriteLine("Enter Counter Number:");
		int counter=Convert.ToInt32(Console.ReadLine());
		//While loop to count down till 1
		while(counter>0){
			Console.WriteLine(counter--);
		}
	}
}