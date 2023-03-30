using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date(MM/DD/YYYY)");
        DateTime date=DateTime.Parse(Console.ReadLine());
        string longDateFormat=date.ToLongDateString();
        Console.WriteLine($"The long date format of {date.ToShortDateString()} is {longDateFormat}");
    }
}
