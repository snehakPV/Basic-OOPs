using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter the name of person1: ");
       string name1=Console.ReadLine();
       Console.WriteLine("Enter the name of person2: ");
       string name2=Console.ReadLine();
       string lastName1=name1.Substring(name1.LastIndexOf(" ")+1); 
       string lastName2=name2.Substring(name2.LastIndexOf(" ")+1);
       if(string.Compare(lastName1,lastName2)<0)
       {
        Console.WriteLine("Sorted alphabetically by last name: ");
        Console.WriteLine(name1);
        Console.WriteLine(name2);
       }
       else
       {
        Console.WriteLine("Sorted alphabetically by last name: ");
        Console.WriteLine(name2);
        Console.WriteLine(name1);
       }
    }
}
