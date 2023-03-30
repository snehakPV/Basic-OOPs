using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetails
    {
        private static int s_userID = 1000;
        public string UserID { get; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public double Balance { get; set; }
        public UserDetails(string userName, int age, string city, string phone, double balance)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            UserName = userName;
            Age = age;
            City = city;
            Phone = phone;
            Balance = balance;
        }
        public double RechargeBalance(double amount)
        {
            Balance+=amount;
            return Balance;
        }
    }
}