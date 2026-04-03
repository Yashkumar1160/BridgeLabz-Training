using System;
class TravelComputation{
	static void Main(string[]args){
		//Reads inputs for name and cities
		string name=Console.ReadLine();
		string fromCity=Console.ReadLine();
		string viaCity=Console.ReadLine();
		string toCity=Console.ReadLine();
		
		//Reads inputs for distances and times
		double distanceFromToVia=Convert.ToDouble(Console.ReadLine());
		double timeFromToVia=Convert.ToDouble(Console.ReadLine());
		double distanceViaToFinalCity=Convert.ToDouble(Console.ReadLine());
		double timeViaToFinalCity=Convert.ToDouble(Console.ReadLine());
		
		//Compute total distance and total time
		double totalDistance=distanceFromToVia+distanceViaToFinalCity;
		double totalTime=timeFromToVia/timeViaToFinalCity;
		
		//Print travel details
		Console.WriteLine("The results of the trip are : Name:"+name+" from:"+fromCity+" to:"+toCity+" via:"+viaCity+" is "+totalDistance+" km and the Total Time taken is "+totalTime+" minutes");
	}
}