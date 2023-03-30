using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter string1: ");
        string string1=Console.ReadLine();
        Console.WriteLine("Enter string2: ");
        string string2=Console.ReadLine();
        if(string1==string2)
        {
            Console.WriteLine("The length of both strings is equal and also both strings are equal");
        }
        else
        {
            Console.WriteLine("The length of both strings is not equal and both strings are not equal"); 
        }
    }
}
