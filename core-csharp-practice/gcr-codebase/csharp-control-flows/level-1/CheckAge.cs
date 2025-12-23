using System;
class CheckAge{
	static void Main(string[]args){
		//Reads input value of age
		Console.WriteLine("Enter your age: ");
		int age=Convert.ToInt32(Console.ReadLine());
		
		//Checking if the person can vote based on age
		if(age>=18){
			//If age is greater than or equal to 18(can vote)
			Console.WriteLine("The person's age is "+age+" and can vote.");
		}
		else{
			//If age is less than 18(cannot vote)
			Console.WriteLine("The person's age is "+age+" and cannot vote.");
		}
	}
	
}