using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sum: "+Sum(15,16));
    }
    static int Sum(int Number1,int Number2)
    {
      int add=Number1+Number2;
      return add;
    }
}