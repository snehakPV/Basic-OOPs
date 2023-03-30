using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter string1: ");
        string word1=Console.ReadLine();
        System.Console.WriteLine("Enter string2: ");
        string word2=Console.ReadLine();
        int result=String.CompareOrdinal(word1.ToLower(),word2.ToLower());
        if(result<0)
        {
            Console.WriteLine($"String {word1} is less than String {word2}");
        }
        else if(result>0)
        {
            Console.WriteLine($"String {word1} is greater than String {word2}");
        }
        else
        {
            Console.WriteLine($"String {word1} is equal to String {word2}");
        }
    }
}
