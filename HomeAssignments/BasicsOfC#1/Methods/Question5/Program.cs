using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int Number=int.Parse(Console.ReadLine());
        Prime(Number);
       
    }
    static int Prime(int Number)
    {
        int count=0;
        for(int i=1;i<=Number;i++)
        {
            
        if(Number%i==0)
        {
            count++;
        
        }
       
        }
         if(count==2)
        {
            Console.WriteLine(Number+" is Prime number");
        }
        else
        {
            Console.WriteLine(Number+" is not a Prime number");
        }

     return Number;
    }
}
