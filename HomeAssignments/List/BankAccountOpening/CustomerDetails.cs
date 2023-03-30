using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BankAccountOpening
{
    public class CustomerDetails
    {
       private static int s_customerID=1000;

       public string CustomerID { get;}
        public string CustomerName{get;set;}
        public double Balance { get; set; }
        public string Gender{get;set;}
        public long Phone{get;set;}
        public string MailId{get;set;}
        public DateTime DOB{get;set;}
        
        public CustomerDetails(string customerName,double balance,string gender,long phone,string mailID,DateTime dob)
        {
            //increment ID and assign to property
            s_customerID++;
            CustomerID="HDFC"+s_customerID;
            //Assigning parameter to properties
             CustomerName=customerName;
             Balance=balance;
             Gender=gender;
             Phone=phone;
             MailId=mailID;
             DOB=dob;
        }

        
    }
}