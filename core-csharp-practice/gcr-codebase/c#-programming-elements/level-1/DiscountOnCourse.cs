using System;
class DiscountOnCourse{
	static void Main(string[]args){
		//Student fee
		double fee=Convert.ToDouble(Console.ReadLine());
		//Discount Percent
		double discountPercent=Convert.ToDouble(Console.ReadLine());
		//Finding discount and discounted fee
		double discount=fee*discountPercent/100;
		double feeToPay=fee-discount;
		//Output
		Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+feeToPay);
		
		
	}
}