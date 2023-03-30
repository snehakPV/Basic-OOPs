using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string words=Console.ReadLine();
        string upper=words.ToUpper();
        char [] charArray=upper.ToCharArray();
        Array.Reverse(charArray);
        string reverseString=new String(charArray);
        Console.WriteLine("String: "+words);
        System.Console.WriteLine("Uppercase: "+reverseString);
    }
}
