using  System;
class QuotientAndRemainder{
	static void Main(string[]args){
		//Reads number1 and number2 values
		int num1=Convert.ToInt32(Console.ReadLine());
		int num2=Convert.ToInt32(Console.ReadLine());
		
		//Finding quotient and remainder
		int quotient=num1/num2;
		int remainder=num1%num2;
		
		//Output
		Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+num1+" and "+num2);
		
	}
}