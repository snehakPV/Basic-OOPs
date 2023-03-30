using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter date(MM/DD/YYYY)");
        DateTime date=DateTime.Parse(Console.ReadLine());
        DateTime currentDate=DateTime.Today;
        int result=DateTime.Compare(date,currentDate);
        if(result<0)
        {
            System.Console.WriteLine(date+ "is past");
        }
        else if(result==0)
        {
            System.Console.WriteLine(date+ "is today's date");
        }
        else
        {
            System.Console.WriteLine(date+ "is future");
        }
    }
}
