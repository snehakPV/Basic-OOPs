using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter number1: ");  
      int number1=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter number2: ");  
      int number2=int.Parse(Console.ReadLine());
      swap(number1,number2);
    }
    static void swap(int number1,int number2)
    {
        number1=number1+number2;
        number2=number1-number2;
        number1=number1-number2;
       
        Console.WriteLine("1st number: "+number1);
        Console.WriteLine("2nd number: "+number2);
       
    }
}
