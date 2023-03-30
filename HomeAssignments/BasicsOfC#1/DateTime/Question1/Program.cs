using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2016,8,16,3,57,32,11);
        Console.WriteLine("Year= "+date.Year);
        Console.WriteLine("Month= "+date.Month);
        Console.WriteLine("Day= "+date.Day);
        Console.WriteLine("Hour= "+date.Hour);
        Console.WriteLine("Minute= "+date.Minute);
        Console.WriteLine("Second= "+date.Second);
        Console.WriteLine("Millisecond= "+date.Millisecond);
    }
}
