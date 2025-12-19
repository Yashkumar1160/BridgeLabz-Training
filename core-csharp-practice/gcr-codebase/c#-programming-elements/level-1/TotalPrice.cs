using System;
class TotalPrice{
	static void Main(string[]args){
		//Reads the unit price and the quantity
		double unitPrice=Convert.ToDouble(Console.ReadLine());
		int quantity=Convert.ToInt32(Console.ReadLine());
		
		//Calculating total price 
		double totalPrice=unitPrice*quantity;
		//Output
		Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity is "+quantity+" and unit price is INR "+unitPrice);
	}
}