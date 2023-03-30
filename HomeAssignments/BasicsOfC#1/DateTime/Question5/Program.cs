using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        Console.WriteLine(date.AddYears(1));
        Console.WriteLine(date.AddYears(-1));
        
    }
}
