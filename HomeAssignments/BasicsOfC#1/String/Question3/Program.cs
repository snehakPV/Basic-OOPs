using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string input=Console.ReadLine();
        char [] character=input.ToCharArray();
        foreach(char ch in character)
        {
          Console.Write(ch+" ");
        }
        
    }
}
