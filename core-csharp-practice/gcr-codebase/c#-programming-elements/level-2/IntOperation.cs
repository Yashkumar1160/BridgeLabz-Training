using System;
class IntOperation{
	static void Main(string[]args){
		//Reads the value of a, b and c
		int a=Convert.ToInt32(Console.ReadLine());
		int b=Convert.ToInt32(Console.ReadLine());
		int c=Convert.ToInt32(Console.ReadLine());
		
		//Performing integer operations
		int firstOperation=a+b*c;
		int secondOperation=a*b+c;
		int thirdOperation=c+a/b;
		int fourthOperation=a%b+c;
		
		//Output
		Console.WriteLine("The results of Int Operations are "+firstOperation+", "+secondOperation+", "+thirdOperation+" and "+fourthOperation);
		
	}
}