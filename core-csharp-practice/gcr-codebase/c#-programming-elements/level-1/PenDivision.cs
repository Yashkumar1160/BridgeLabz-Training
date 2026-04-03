using System;
class PenDivision{
	static void Main(string[]args){
		//Number of pens and students
		int numberOfPens=14;
		int numberOfstudents=3;
		
		//Equally distributed and remaining pens
		int distributedPens=14/3;
		int remainingQuantity=14%3;
		//Output
		Console.WriteLine("The Pen Per Student is "+distributedPens+" and the remaining pen not distributed is "+remainingQuantity);
		
	}
}