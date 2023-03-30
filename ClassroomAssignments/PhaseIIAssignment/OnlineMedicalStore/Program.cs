using System;
namespace OnlineMedicalStore;
class Program
{
    public static void Main(string[] args)
    {
        Operation operate=new Operation();
        operate.DefaultDate();
        operate.MainMenu();
    }
}
