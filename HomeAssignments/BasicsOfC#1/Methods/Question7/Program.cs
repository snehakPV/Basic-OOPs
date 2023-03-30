using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter input1: ");
        int input1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter input2: ");
        int input2=int.Parse(Console.ReadLine());
        Program program=new Program();
        int Add=program.Addition(input1,input2);
        int Subtract=program.Subtraction(input1,input2);
        int Multiply=program.Multiplication(input1,input2);
        int Divide=program.Division(input1,input2);
        Console.WriteLine("Addition="+Add);
        Console.WriteLine("Subtraction="+Subtract);
        Console.WriteLine("Multiplication="+Multiply);
        Console.WriteLine("Division="+Divide);
    }
    int result;
    public int Addition(int input1,int input2)
        {
           return result=input1+input2;
        }
        public int Subtraction(int input1,int input2)
        {
           return result=input1-input2;
        }
        public int Multiplication(int input1,int input2)
        {
           return result=input1*input2;
        }
        public int Division(int input1,int input2)
        {
           return result=input1/input2;
        }
}
