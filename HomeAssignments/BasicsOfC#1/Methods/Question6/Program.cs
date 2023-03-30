using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter mark1");
        int mark1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark2");
        int mark2=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark3");
        int mark3=int.Parse(Console.ReadLine());
        double percentage=CalculatePercentage(mark1,mark2,mark3);
        Console.WriteLine($"Mark1:{mark1}\nMark2:{mark2}\nMark3:{mark3}");
        Console.WriteLine("Percentage: "+percentage);
    }
    static double CalculatePercentage(int mark1,int mark2,int mark3)
    {
      int totalMarks=300;
      int marks=mark1+mark2+mark3;
      double percentage=(marks+100.0)/totalMarks;
      return percentage;
    }
}
