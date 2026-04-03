using System;
class NumberOfHandshakes{
	static void Main(string[]args){
		//Reads number of students
		int numberOfStudents=Convert.ToInt32(Console.ReadLine());
		//Calculating total number of Handshakes
		int numberOfHandshakes=(numberOfStudents*(numberOfStudents-1))/2;
		//Output
		Console.WriteLine("The possible number of handshakes is "+numberOfHandshakes);
	}
}