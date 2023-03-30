using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string words=Console.ReadLine().ToLower();
        int vowels=0;
        int consonants=0;
        for(int i=0;i<words.Length;i++)
        {
            char c=words[i];
            if(c=='a'|| c=='e'||c=='i'||c=='o'||c=='u')
            {
                vowels++;
            }
            else if(c=='b'&&c=='z'&&c!='e'||c!='i'||c!='o'||c!='u')
            {
                consonants++;
            }
        }
        System.Console.WriteLine("Vowels:"+vowels);
        System.Console.WriteLine("Consonants:"+consonants);
    }
}
