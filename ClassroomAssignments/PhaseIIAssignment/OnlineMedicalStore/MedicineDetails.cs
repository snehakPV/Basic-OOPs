using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineID = 100;
        public string MedicineID { get; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public MedicineDetails(string medicineName, int availableCount, double price, DateTime expiryDate)
        {
            s_medicineID++;
            MedicineID = "MD" + s_medicineID;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            ExpiryDate = expiryDate;
        }

    }
}