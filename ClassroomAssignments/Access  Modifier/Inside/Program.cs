using System;
namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        //public class
        First one=new First();
        Console.WriteLine(one.PublicNumber);

        //private class
        //Inaccessible due to its protection level
        //Console.WriteLine(one.PrivateNumber);
        Console.WriteLine(one.PrivateOut);

        //internal class
        Console.WriteLine(one.InternalNumber);

        //protected class - inaccessible due to protection level
        //Console.WriteLine(one.ProtectedNumber);
        Console.WriteLine(one.ProtectedFirst);

        //object for second class
        Second two=new Second();
        //calling object from second class using inheritance
        Console.WriteLine(two.ProtectedSecond);
        //calling object from third class using inheritance
        Console.WriteLine(one.ProtectedInternalOut);
    }
}