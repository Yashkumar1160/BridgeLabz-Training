using System;
class ProfitAndLoss{
	static void Main(string[]args){
		//Cost price 
		int costPrice=129;
		//Selling Price
		int sellingPrice=191;
		//Calculating profit 
		int profit=sellingPrice-costPrice;
		double profitPercentage=profit/(double)costPrice*100;
		//Output
		Console.WriteLine("The Cost Price is INR "+costPrice+" and Selling Price is INR "+sellingPrice+"\nThe Profit is INR "+profit+" and the Profit Percentage is "+profitPercentage);
	}
}