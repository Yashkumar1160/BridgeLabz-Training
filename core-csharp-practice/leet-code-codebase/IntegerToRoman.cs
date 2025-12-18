using System;
using System.Text;

public class IntegerToRoman {
    public static void Main(string[] args) {
 
        //Read integer input
        int num=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Roman(num));
    }
    //Method to convert integer to roman
    public static string Roman(int num){
        //Roman numeral symbols and values
        int []roman={1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string[] symbols={"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        StringBuilder r=new StringBuilder();

        for(int i=0;i<roman.Length;i++){
            while(num>=roman[i]){
                r.Append(symbols[i]);
                num-=roman[i];
            }
        }
        return r.ToString();
    }
}
