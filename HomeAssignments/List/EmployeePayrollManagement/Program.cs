using System;
using System.Collections.Generic;
namespace EmployeePayrollManagement;
class Program
{
     static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
    public static void Main(string[] args)
    {
        string option=string.Empty;
       do{
        Console.WriteLine("Select from the following:\n1.Registration\n2.Login\n3.Exit");
        int Select=int.Parse(Console.ReadLine());
        switch(Select)
        {
            case 1:
            {
                Registration();
                break;
            }
            case 2:
            {
                Login();
                break;
            }
            case 3:
            {
                break;
            }
        }
        Console.WriteLine("Do you want to continue the process:(Yes/No)");
        option=Console.ReadLine().ToLower();
       }while(option=="yes");
    }
    public static void Registration()
    {
        Console.WriteLine("Enter your name: ");
        string employeeName=Console.ReadLine();
        Console.WriteLine("Enter your role: ");
        string role=Console.ReadLine();
        Console.WriteLine("Enter your location: ");
        WorkLocation location=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
        Console.WriteLine("Enter your team name: ");
        string teamName=Console.ReadLine();
        Console.WriteLine("Date of joining: ");
        string dateOfJoining=Console.ReadLine();
        Console.WriteLine("Number of working days in month: ");
        int numberOfWorkingDays=int.Parse(Console.ReadLine());
        Console.WriteLine("Number of days leave taken: ");
        int numberOfLeaveTaken=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your gender: ");
        Gender employeeGender=Enum.Parse<Gender>(Console.ReadLine(),true);
        EmployeeDetails employee=new EmployeeDetails(employeeName,role,location,teamName,dateOfJoining,numberOfWorkingDays,numberOfLeaveTaken,employeeGender);
        employeeList.Add(employee);
        Console.WriteLine("Registered Successfully!\nYour Employee ID: "+employee.EmployeeID);
    }
    public static void Login()
    {
        Console.WriteLine("Enter your Employee ID: ");
        string employeeID=Console.ReadLine();
        bool flag=true;
        foreach(EmployeeDetails employeeDetails in employeeList )
        {
            if(employeeID==employeeDetails.EmployeeID)
            {
                Console.WriteLine("Login Successful!");
                flag=false;
                Submenu();
                
            }
        }
        if(flag)
        {
            Console.WriteLine("Invalid Employee ID");
        }
    }
    public static void Submenu()
    {
        string option=string.Empty;
        do{
      Console.WriteLine("Select from the following:\n1.Calculate Salary\n2.Display Details\n3.Exit");
      int Select=int.Parse(Console.ReadLine());
      switch(Select)
      {
        case 1:
        {
           foreach(EmployeeDetails employeeDetails in employeeList )
           {
           double finalSalary=employeeDetails.SalaryCalculation(employeeDetails.NumberOfWorkingDays,employeeDetails.NumberOfLeaveTaken);
            Console.WriteLine("Salary="+finalSalary);
           }
        break;
        }
        case 2:
        {
            foreach(EmployeeDetails employeeDetails in employeeList )
            {
                Console.WriteLine(employeeDetails.EmployeeID);
                Console.WriteLine(employeeDetails.EmployeeName);
                Console.WriteLine(employeeDetails.Role);
                Console.WriteLine(employeeDetails.TeamName);
                Console.WriteLine(employeeDetails.EmployeeGender);
                Console.WriteLine(employeeDetails.DateOfJoining);
                Console.WriteLine(employeeDetails.Location);
                Console.WriteLine(employeeDetails.NumberOfWorkingDays);
                Console.WriteLine(employeeDetails.NumberOfLeaveTaken);
            }
            break;
        }
        case 3:
        {
            break;
        }
      }
      Console.WriteLine("Do you want to continue the process:(yes/no)");
      option=Console.ReadLine().ToLower();
        }while(option=="yes");
    }
}
