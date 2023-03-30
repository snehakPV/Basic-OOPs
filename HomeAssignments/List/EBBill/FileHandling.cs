using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBill
{
    public class FileHandling
    {
        public void Create()
        {
          if(!Directory.Exists("EBBill"))
          {
            System.Console.WriteLine("Creating Folder..");
            Directory.CreateDirectory("EBBill");
          }
          if(!File.Exists("EBBill/EBMeterDetails.csv"))
          {
            System.Console.WriteLine("Creating File EBMeterDetails");
            File.Create("EBBill/EBMeterDetails.csv").Close();
          }
          if(!File.Exists("EBBill/UserDetails.csv"))
          {
            System.Console.WriteLine("Creating File UserDetails");
            File.Create("EBBill/UserDetails.csv").Close();
          }
        }
        public void WriteToCSV()
        {
            string [] entries=new string[Operations.entryList.Count];
            for(int i=0;i<Operations.entryList.Count;i++)
            {
                var entry=Operations.entryList[i];
                entries[i]=entry.EntryID+","+entry.CustomerID+","+entry.UnitUsed+","+entry.MeterTarrifType+","+entry.BillDate+","+entry.Status+","+entry.BillAmount;
            }
            File.WriteAllLines("EBBill/EBMeterDetails.csv",entries);
            string[] users=new String[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                var user=Operations.userList[i];
                users[i]=user.CustomerID+","+user.Name+","+user.Phone+","+user.Address+","+user.Balance;
            }
            File.WriteAllLines("EBBill/UserDetails.csv",users);
        }
        public void ReadFromCSV()
        {
            string [] users=File.ReadAllLines("EBBill/UserDetails.csv");
            for(int i=0;i<users.Length;i++)
            {
                Operations.userList.Add(new UserDetails(users[i]));
            }
            string [] entries=File.ReadAllLines("EBBill/EBMeterDetails.csv");
            for(int i=0;i<entries.Length;i++)
            {
                Operations.entryList.Add(new EBMeterDetails(entries[i]));
            }
        }
    }
}