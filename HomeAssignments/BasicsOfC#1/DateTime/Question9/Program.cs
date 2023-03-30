using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Leap years between 1994 and 2023");
        for(int year=1994;year<=2023;year++)
        {
            if(DateTime.IsLeapYear(year))
            {
                System.Console.WriteLine(year);
            }
        }
    }
}
