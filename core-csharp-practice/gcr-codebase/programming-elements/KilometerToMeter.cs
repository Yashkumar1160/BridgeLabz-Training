using System;
class KilometerToMeter{
    static void Main(string[]args) {
        //Reads kilometer value
        double km=Convert.ToDouble(Console.ReadLine());
        //Calculating miles value
        double miles=km*0.621371;
        Console.WriteLine("Miles values is : "+miles);

    }
}

}