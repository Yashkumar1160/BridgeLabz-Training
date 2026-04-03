using System;
class StudentGrade{
	static void Main(string[]args){
		//read input values of different marks
		Console.WriteLine("Enter Physics Marks: ");
		double physics=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter Chemistry Marks: ");
		double chemistry=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter Maths Marks: ");
		double maths=Convert.ToDouble(Console.ReadLine());
		
		//finding  percentage marks
		double percentMarks=(physics+chemistry+maths)/3;
		
		//finding grade with respect to Percent Marks
		if(percentMarks>=80){
			Console.WriteLine("Grade A, Remark: Level 4, above agency-normalized standards");
		}
		else if(percentMarks>=70 && percentMarks<=79){
			Console.WriteLine("Grade B, Remark: Level 3, at agency-normalized standards");
		}
		else if(percentMarks>=60 && percentMarks<=69){
			Console.WriteLine("Grade C : Remark: Level 2, below, but approaching agency-normalized standards");
		}
		else if(percentMarks>=50 && percentMarks<=59){
			Console.WriteLine("Grade D : Remark: Level 1, well below agency-normalized standards");
		}
		else if(percentMarks>=40 && percentMarks<=49){
			Console.WriteLine("Grade E : Remark: Level 1, too below agency-normalized standards");
		}
		else{
			Console.WriteLine("Grade R : Remark: Remedial standards");
		}
			
		
	}
}