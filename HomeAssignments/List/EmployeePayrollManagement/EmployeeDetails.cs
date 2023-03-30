using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement
{
    public enum WorkLocation{Select,Chennai,Mumbai,Bangalore}
    public enum Gender{Select,Male,Female}
    public class EmployeeDetails
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public WorkLocation Location { get; set; }
        public string TeamName { get; set; }
        public string DateOfJoining { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public int NumberOfLeaveTaken { get; set; }
        public Gender EmployeeGender { get; set;}
        public EmployeeDetails(string employeeName,string role,WorkLocation location,string teamName,string dateOfJoining,int numberOfWorkingDays,int numberOfLeaveTaken,Gender employeeGender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            EmployeeName=employeeName;
            Role=role;
            Location=location;
            TeamName=teamName;
            DateOfJoining=dateOfJoining;
            NumberOfWorkingDays=numberOfWorkingDays;
            NumberOfLeaveTaken=numberOfLeaveTaken;
            EmployeeGender=employeeGender;
        }
        public double SalaryCalculation(int NumberOfWorkingDays,int numberOfLeaveTaken)
        {
         double Salary=NumberOfWorkingDays*500;
         Salary-=NumberOfLeaveTaken*500;
         return Salary;

        }

        
        
        
        
        
        
        
    }
}