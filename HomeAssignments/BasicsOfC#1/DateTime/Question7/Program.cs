using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month:");
        int month=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the year:");
        int year=int.Parse(Console.ReadLine());
        int daysInMonth=DateTime.DaysInMonth(year,month);
        Console.WriteLine($"There are {daysInMonth}");
    }
}
