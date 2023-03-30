using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBill
{
    /// <summary>
    /// Class <see cref="UserDetails"/> used to collect customer details from user
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Static field used to auto increment and it uniquely identify an instance of 
        /// <see cref="Customerinfo" /> class
        /// For further reference Click <see href="www.syncfusion.com">Syncfusion</see>
        /// </summary>
         private static int s_customerID=1000;
          /// <summary>
          /// Property CustomerID used to provide user CustomerID
          /// </summary>
          /// <value></value>
         public string CustomerID { get; }
         /// <summary>
         /// Property name used to provide customer name
         /// </summary>
         /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Property Phone used to provide user phone number
        /// </summary>
        /// <value></value>
        public string Phone { get; set; }
        /// <summary>
        /// Field balance used to store user balance
        /// </summary>
        private double _balance;
        /// <summary>
        /// Property balance used to store users balance
        /// </summary>
        /// <value></value>
        public double Balance{get{return _balance;}}
        /// <summary>
        /// Property Address used to user Address
        /// </summary>
        /// <value></value>
        public string Address { get; set; }
        /// <summary>
        /// Constructor of<see cref="UserDetails"/> class used to initialize the value to property
        /// </summary>
        /// <param name="name">parameter name used to initialize the name to property Name</param>
        /// <param name="phone">parameter phone used to initialize phone number to the property Phone</param>
        /// <param name="address">parameter phone used to initialize address to the property Address</param>

        public UserDetails(string name,string phone,string address)
        {
            s_customerID++;
            CustomerID="EB"+s_customerID;
            Name=name;
            Phone=phone;
            Address=address;
        }
        public UserDetails(string user)
        {
            string [] values=user.Split(",");
            CustomerID=values[0];
            s_customerID=int.Parse(values[0].Remove(0,2));
            Name=values[1];
            Phone=values[2];
            Address=values[3];
            _balance=double.Parse(values[4]);
        }
        /// <summary>
        /// Method Recharge contains the balance amount after recharge
        /// </summary>
        /// <param name="amount">used to amount for recharge</param>
        public void Recharge(double amount)
        {
          _balance=_balance+amount;
        }
        /// <summary>
        /// Method DeductBalance contains the balance amount after deducting the amount
        /// </summary>
        /// <param name="amount">used to provide amount to deduct</param>
        public void DeductBalance(double amount)
        {
            
            _balance-=amount;
        }
    }
}