using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
      int number=23454567;
      int index=5;
      int digit=NthDigit(number,index);
      Console.WriteLine($"The {index}th digit of {number} is {digit}");
    }
    public static int NthDigit(int number,int index)
    {
        int numDigits=(int)Math.Log10(number)+1;
        int digitIndex=numDigits-index;
        int digit=(int)(number/Math.Pow(10,digitIndex))%10;
        return digit;
    }
}
