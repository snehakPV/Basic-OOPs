using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public enum OrderStatus { Select, Purchased, Cancelled }
    public class OrderDetails
    {
        private static int s_orderID = 2000;
        public string OrderID { get; }
        public string UserID { get; set; }
        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public OrderDetails(string userID, string medicineID, int medicineCount, double totalPrice, DateTime orderDate, OrderStatus status)
        {
            s_orderID++;
            OrderID="OID"+ s_orderID;
            UserID = userID;
            MedicineID = medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            Status = status;
        }
    }
}