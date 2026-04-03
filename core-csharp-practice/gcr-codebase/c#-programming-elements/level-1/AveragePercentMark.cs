using System;
class AveragePercentMark{
	static void Main(string[]args){
		//Sam's marks in Maths, Physics and Chemistry
		int maths=94;
		int physics=95;
		int chemistry=96;
		
		//Finding average percent 
		int total=maths+physics+chemistry;
		double averagePercent=(total/300.0)*100;
		//Output
		Console.WriteLine("Sam's average mark in PCM is "+averagePercent);
	}
}