using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter date1(MM/DD/YYYY)");
        DateTime date1=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter date2(MM/DD/YYYY)");
        DateTime date2=DateTime.Parse(Console.ReadLine());
        TimeSpan difference=date2-date1;
        int daysDifference=difference.Days;
        System.Console.WriteLine($"The difference between {date1.ToShortDateString()} and {date2.ToShortDateString()} is {daysDifference} days");
    }
}
