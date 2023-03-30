using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Data();
    }

    static void Data()
    {
     Console.WriteLine("Please input a String: ");
     String input=Console.ReadLine();
     String []input1=input.Split(" ");
     int result=input1.Length-1;
     Console.WriteLine(input+" contains "+result+" spaces ");
    }
}
