using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
       Array(); 
    }
    static void Array()
    {
        int [] arr={5,7,3,2,9};
        int sum=0;
        for(int i=0;i<arr.Length;i++)
        {
         sum+=arr[i];
        }
        Console.WriteLine("Sum= "+sum);
    }
}
