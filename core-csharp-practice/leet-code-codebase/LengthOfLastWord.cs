using System;

public class LengthOfLastWord {
    public static void Main(string[] args) {
        //Read complete string
        string s=Console.ReadLine();
        //Call method to print length of last word
        Console.WriteLine(LastWordLength(s));
    }
    //Method to find the length of last word
    public static int LastWordLength(string s){
        int length=0;
        int i=s.Length-1;

        //Skip the spaces
        while(i>=0 &&s[i]==' '){
            i--;
        }
        //Count the characters of the last word
        while(i>=0&&s[i]!=' '){
            length++;
            i--;
        }
        return length;
    }
}
