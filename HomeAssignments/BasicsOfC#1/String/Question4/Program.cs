using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string words=Console.ReadLine();
        string [] word=words.Split(" ");
        int count=0;
        for(int i=0;i<word.Length;i++)
        {
         Console.WriteLine(word[i]);
         count++;
        }
        Console.WriteLine(count);
    }
}
