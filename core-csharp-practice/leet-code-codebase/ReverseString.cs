using System;
public class ReverseString{
    public static void Main(string[]args){
        //Read a string 
        string str=Console.ReadLine();
        //Convert string to character array
        char[]s=str.ToCharArray();
        //Call reverse method
        Console.WriteLine(Reverse(s));
    }
    //Method to reverse character array and return reversed string 
    public static string Reverse(char[]s){
        int start=0;
        int end=s.Length-1;

        //Swap characters until start crosses end
        while(start<end){
            Swap(s,start,end);
            start++;
            end--;
        }

        //convert reversed character array to string 
        return new string(s);

    }

    //Method to swap two characters in the array
    public static void Swap(char[]s,int start,int end){
        char temp=s[start];
        s[start]=s[end];
        s[end]=temp;
    }
}