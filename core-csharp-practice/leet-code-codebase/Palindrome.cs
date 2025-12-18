using System;

public class Palindrome{
    public static void Main(string[]args){
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PalindromeCheck(num));
    }
    public static bool PalindromeCheck(int num){
        if(num<0){
            return false;
        }
        int org=num;
        int rev=0;
        while(num!=0){
            int rem=num%10;
            rev=rev*10+rem;
            num=num/10;
        }
        return rev==org;
    }
}