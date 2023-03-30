using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string words=Console.ReadLine();
        System.Console.WriteLine("Enter the string to search:");
        string search=Console.ReadLine();
        System.Console.WriteLine("Enter the string to insert: ");
        string insert=Console.ReadLine();
        int index=words.IndexOf(search);
        insert=" "+insert.Trim()+" ";
        words=words.Insert(index,insert);
        Console.WriteLine($"The String is: "+words);
    }
}
