using System;
class Car{
	//Making carName variable as public 
	public string carName="Mustang";
	
	//Making color variable as private
	private string color="Black";
	
	//Making fuelType variable as internal
	internal string fuelType="Petrol";
	
	//Making speed variable as protected
	protected int speed=300;
	
	//Making company variable as protected internal
	protected internal string company="Ford";
	
	//Making modelYear variable as private protected
	//private protected int modelYear=1969; this modifier is not supported in C# 5
	
	//private member is only accessible inside same class
	public void ShowColor(){
		Console.WriteLine("Car color is :"+color);
	}
}
class SportsCar:Car{
	public void ShowDetails(){
		
		//public member is accessible everywhere
		Console.WriteLine("SportsCar Name is :"+carName);
		
		//private member is accessible only in same class
		Console.WriteLine("SportsCar Color cannot be asscessed here as it is private");
		
		//internal member is accessible in same project
		Console.WriteLine("SportsCar fuel types is :"+fuelType);
		
		//protected internal member is accessible in same project or child class
		Console.WriteLine("SportsCar company is :"+company);
		
		//protected member is accessible in parent and child class
		Console.WriteLine("SportsCar speed is :"+speed);
		
		//private protected member is accessible in parent and child class
		//Console.WriteLine("SportsCar modelYear is :"+modelYear);
	}
}

class AccessModifiers{
	
	//Main method
	static void Main(string[]args){
		//Creating object for class Car
		Car obj=new Car();
		
		//Output
		Console.WriteLine("Car Name is :"+obj.carName);
		Console.WriteLine("Car fuel types is :"+obj.fuelType);
		Console.WriteLine("Car company is :"+obj.company);
		Console.WriteLine("Car speed cannot be asscessed here as it is protected");
		Console.WriteLine("Car modelYear cannot be asscessed here as it is private protected");
		Console.WriteLine("Car Color cannot be asscessed here as it is private");
		Console.WriteLine("Private member color can be accessed by using public ShowColor method");
		//Calling ShowColor method
		obj.ShowColor();
		
		//Creating object for class SportsCar
		SportsCar sp=new SportsCar();
		//Calling ShowDetails method
		sp.ShowDetails();
		
	}

}