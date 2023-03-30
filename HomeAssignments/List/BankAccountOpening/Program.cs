using System;
using System.Collections.Generic;
namespace BankAccountOpening
{
class Program
{

    public static void Main(string[] args)
    {
        List<CustomerDetails> customerList=new List<CustomerDetails>();
        string choice=string.Empty;
        do{
        Console.WriteLine("Select from the following:\n1.Registration\n2.Login\n3.Exit");
        int select=int.Parse(Console.ReadLine());
        switch(select)
        {
            case 1:
            {
                //Console.WriteLine("Enter your ID: ");
                //string customerID=Console.ReadLine();
                Console.WriteLine("Enter your name: ");
                string customerName=Console.ReadLine();
                Console.WriteLine("Enter your balance: ");
                double balance=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your gender: ");
                string gender=Console.ReadLine();
                Console.WriteLine("Enter your Dob(dd/MM/yyyy): ");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                Console.WriteLine("Enter your Mobile number: ");
                long phone=long.Parse(Console.ReadLine());
                Console.WriteLine("Enter your MailId: ");
                string mailID=Console.ReadLine();
                CustomerDetails customer=new CustomerDetails(customerName,balance,gender,phone,mailID,dob);
                customerList.Add(customer);
                Console.WriteLine($"Successfully Registered!\nYour ID is {customer.CustomerID}");
                break;
            }
            case 2:
            {
                //CustomerDetails customer=new CustomerDetails(customerID,customerName,balance,gender,phone,mailID,dob);
                Console.WriteLine("Enter your Id to login: ");
                string loginID=Console.ReadLine().ToUpper();
                
                foreach(CustomerDetails customer1 in customerList)
                {
                    
                
                if(customer1.CustomerID==loginID)
                {
                    
                    Console.WriteLine($"Customer Name:{customer1.CustomerName}\nGender:{customer1.Gender}\nPhone:{customer1.Phone}\nMailId:{customer1.MailId}\nDate of Birth:{customer1.DOB}");
                    Console.WriteLine("Select from the following:\n1.Deposit\n2.Withdraw\n3.Check Balance\n4.Exit");
                    int option = int.Parse(Console.ReadLine());
                    switch(option){
                    case 1:
                    {
                        Console.WriteLine("Enter the amount to Deposit: ");
                        double deposit=double.Parse(Console.ReadLine()); 
                        customer1.Balance+=deposit;
                        Console.WriteLine("Current balance= "+customer1.Balance);
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter the amount to be withdrawn: ");
                        double withdrawn=double.Parse(Console.ReadLine());
                        customer1.Balance-=withdrawn;
                        Console.WriteLine("Current balance= "+customer1.Balance);
                        break;
                    }
                    case 3:
                    {
                       Console.WriteLine("Balance = "+customer1.Balance);
                        break;
                    }
                    case 4:
                    {
                        break;
                    }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid User Id!");
                }
                }
                
                break;
            }
            case 3:
            {
                choice="no";
                break;
            }
        }
        Console.WriteLine("Do you want to continue the process: (yes/no)");
        choice=Console.ReadLine();
        }while(choice=="yes");
        
    }
}
}
