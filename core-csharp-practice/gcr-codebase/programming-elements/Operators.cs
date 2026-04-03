using System;
class Operators{
	static void Main(string[]args){
		int num1=15;
		int num2=5;
		
		
		//Arithmetic Operators
		Console.WriteLine("Arithmetic Operators: ");
		Console.WriteLine("num1: "+num1+" num2: "+num2);
		//Addition Operator(+)
		Console.WriteLine("Addition: "+(num1+num2));
		//Subtraction Operator(-)
		Console.WriteLine("Subtraction: "+(num1-num2));
		//Multiplication Operator(*)
		Console.WriteLine("Multiplication: "+(num1*num2));
		//Division Operator(/)
		Console.WriteLine("Division: "+(num1/num2));
		//Modulus Operator(%)
		Console.WriteLine("Modulus: "+(num1%num2));
		
		
		//Relational Operator
		Console.WriteLine("Relational Operators: ");
		//Equal to Operator(==)
		Console.WriteLine("num1==num2: "+(num1==num2));
		//Not equal to Operator(!=)
		Console.WriteLine("num1!=num2: "+(num1!=num2));
		//Greater Than Operator(>)
		Console.WriteLine("num1>num2: "+(num1>num2));
		//Less Than Operator(<)
		Console.WriteLine("num1<num2: "+(num1<num2));
		//Greater than or equal to Operator(>=)
		Console.WriteLine("num1>=num2: "+(num1>=num2));
		//Less than or equal to Operator(<=)
		Console.WriteLine("num1<=num2: "+(num1<=num2));
		
		
		//Logical Operator
		Console.WriteLine("Logical Operators: ");
		bool x=true;
		bool y=false;
		Console.WriteLine("x: "+x+" y: "+y);
		//Logical AND(&&) Operator
		Console.WriteLine("x&&y: "+(x&&y));
		//Logical OR(||) Operator
		Console.WriteLine("x||y: "+(x||y));
		//Logical NOT(!) Operator
		Console.WriteLine("!y: "+(!y));
		
		
		//Assignment Operators
		Console.WriteLine("Assignment Operators: ");
		//Assignment Operator(=)
		int c=10;
		int d=4;
		Console.WriteLine("c=10");
		Console.WriteLine("d=4");
		//Addition Assignment Operator(+=)
		c+=d;
		Console.WriteLine("c+=d: "+c);
		//Subtraction Assignment Operator(-=)
		c-=d;
		Console.WriteLine("c-=d: "+c);
		//Multiplication Assignment Operator(*=)
		c*=d;
		Console.WriteLine("c*=d: "+c);
		//Division Assignment Operator(/=)
		c/=d;
		Console.WriteLine("c/=d: "+c);
		//Modulous Assignment Operator(%=)
		c%=d;
		Console.WriteLine("c%=d: "+c);
		
		
		//Unary Operators
		Console.WriteLine("Unary Operators: ");
		int a=5;
		//Unary Plus Operator(+)
		Console.WriteLine("+a: "+ +a);
		//Unary Minus Operator(-)
		Console.WriteLine("-a: "+ -a);
		//Unary Increment Operator(++)
		Console.WriteLine("++a: "+ ++a);//Pre-increment
		Console.WriteLine("a++: "+ a++);//Post-increment
		Console.WriteLine("a: "+a);
		//Unary Decrement Operator(--)
		Console.WriteLine("--a: "+ --a);//Pre-decrement
		Console.WriteLine("a--: "+ a--);//Post-decrement
		Console.WriteLine("a: "+a);
		
		
		//Ternary Operator
		Console.WriteLine("Ternary Operators: ");
		int max=(num1>num2)? num1:num2;
		Console.WriteLine("Max: "+max);
		
		
		//is Operator
		Console.WriteLine("is Operator: ");
		Operators op=new Operators();
		Console.WriteLine("operator is Operators:"+(op is Operators));
		Console.WriteLine("operator is string:"+(op is string));
		
	}
}