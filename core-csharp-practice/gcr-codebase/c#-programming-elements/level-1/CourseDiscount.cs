using System;
class CourseDiscount{
	static void Main(string[]args){
		//Student fee
		int fee=125000;
		//Discount Percent
		int discountPercent=10;
		
		//Finding discount and reduced fee
		int discount=fee*10/100;
		int feeToPay=fee-discount;
		
		//Output
		Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+feeToPay);
		
		
	}
}