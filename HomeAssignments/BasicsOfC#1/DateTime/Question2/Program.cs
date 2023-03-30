using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        DateTime data=DateTime.Now;
        Console.WriteLine("40 days from now: "+data.AddDays(40));

    }
}