using System;
namespace Question2;
class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Input the String: ");
    string Input=Console.ReadLine();
    int count=0;
    foreach(char character in Input)
    {
    count++;
    }
    Console.WriteLine("The length of string: "+count);
}
}