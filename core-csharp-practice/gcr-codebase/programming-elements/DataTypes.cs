using System;
class DataTypes{
	static void Main(string[]args){
	
		//byte datatype
		byte byteValue=100;
		Console.WriteLine("byte: "+byteValue);
		
		//short datatype
		short shortValue=400;
		Console.WriteLine("short: "+shortValue);
	
	
		//integer datatype
		int integerValue=10000;
		Console.WriteLine("integer: "+integerValue);
		
		//float datatype
		float floatValue=10.2f;
		Console.WriteLine("float: "+floatValue);
		
		//double datatype
		double doubleValue=123.93D;
		Console.WriteLine("double: "+doubleValue);
		
		//long datatype
		long longValue=13421412L;
		Console.WriteLine("long: "+longValue);
		
		//bool datatype
		bool boolValue=true;
		Console.WriteLine("bool: "+boolValue);
		
		//char datatype
		char chracterValue='c';
		Console.WriteLine("char: "+chracterValue);
		
		//Implicit Type Casting
		short s=10;
		int i=s;
		long l=i;
		float f=l;
		double d=f;
		Console.WriteLine("Implicit Casting: ");
		Console.WriteLine("short->"+s);
		Console.WriteLine("short->int:"+i);
		Console.WriteLine("int->long:"+l);
		Console.WriteLine("long->float:"+f);
		Console.WriteLine("float->double:"+d);
		
		//Explicit Type Casting
		double d2=123.45;
		float f2=(float)d2;
		long l2=(long)f2;
		int i2=(int)l2;
		short s2=(short)i2;
		Console.WriteLine("Explicit Casting: ");
		Console.WriteLine("double->"+d2);
		Console.WriteLine("double->float:"+f2);
		Console.WriteLine("float->long:"+l2);
		Console.WriteLine("long->int:"+i2);
		Console.WriteLine("int->short:"+s2);
		
		
		
		
		
		
	}
}