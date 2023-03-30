using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class Operation
    {
        List<UserDetails> userList = new List<UserDetails>();
        List<MedicineDetails> medicineList = new List<MedicineDetails>();
        List<OrderDetails> orderList = new List<OrderDetails>();
        UserDetails currentUser;
        private int medicineCount;
        private double totalPrice;
        private string userID;

        public void DefaultDate()
        {
            UserDetails defaultUser1 = new UserDetails("Ravi", 33, "Theni", "9877774440", 400);
            UserDetails defaultUser2 = new UserDetails("Baskaran", 33, "Chennai", "8847757470", 500);
            userList.Add(defaultUser1);
            userList.Add(defaultUser2);
            MedicineDetails defaultMedicine1 = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2023, 06, 30));
            MedicineDetails defaultMedicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2023, 05, 30));
            MedicineDetails defaultMedicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2023, 04, 30));
            MedicineDetails defaultMedicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2022, 12, 30));
            MedicineDetails defaultMedicine5 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2023, 10, 30));
            medicineList.Add(defaultMedicine1);
            medicineList.Add(defaultMedicine2);
            medicineList.Add(defaultMedicine3);
            medicineList.Add(defaultMedicine4);
            medicineList.Add(defaultMedicine5);
            OrderDetails defaultOrder1 = new OrderDetails("UID1001", "MD101", 3, 15, new DateTime(2022, 11, 13), OrderStatus.Purchased);
            OrderDetails defaultOrder2 = new OrderDetails("UID1001", "MD102", 2, 10, new DateTime(2022, 11, 13), OrderStatus.Cancelled);
            OrderDetails defaultOrder3 = new OrderDetails("UID1001", "MD104", 2, 100, new DateTime(2022, 11, 13), OrderStatus.Purchased);
            OrderDetails defaultOrder4 = new OrderDetails("UID1002", "MD103", 3, 120, new DateTime(2022, 11, 15), OrderStatus.Cancelled);
            OrderDetails defaultOrder5 = new OrderDetails("UID1002", "MD105", 5, 250, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            OrderDetails defaultOrder6 = new OrderDetails("UID1002", "MD102", 3, 15, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            orderList.Add(defaultOrder1);
            orderList.Add(defaultOrder2);
            orderList.Add(defaultOrder3);
            orderList.Add(defaultOrder4);
            orderList.Add(defaultOrder5);
            orderList.Add(defaultOrder6);
            /* foreach(UserDetails user in userList)
             {
                 Console.WriteLine($"{user.UserName}|{user.Age}|{user.City}|{user.Phone}|{user.Balance}");
             }
             foreach(MedicineDetails medicine in medicineList)
             {
                 Console.WriteLine($"{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.ExpiryDate}");
             }
             foreach(OrderDetails order in orderList)
             {
                 Console.WriteLine($"{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate}|{order.Status}");
             }*/
        }
        public void MainMenu()
        {
            int Option;
            do
            {
                Console.WriteLine("Select from the following:\n1.Registration\n2.Login\n3.Exit");
                Option = int.Parse(Console.ReadLine());
                switch (Option)
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
                }
            } while (Option < 2);
        }
        public void Registration()
        {
            Console.WriteLine("Enter your Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter your Balance: ");
            double balance = double.Parse(Console.ReadLine());
            UserDetails userDetails = new UserDetails(userName, age, city, phone, balance);
            userList.Add(userDetails);
            Console.WriteLine("Registered Successfully!\nYour User ID: " + userDetails.UserID);
        }
        public void Login()
        {
            Console.WriteLine("Enter you User ID: ");
            string userID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userList)
            {
                if (userID == user.UserID)
                {
                    flag = false;
                    currentUser = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User ID!\nPlease enter a valid one.");
            }
        }
        public void SubMenu()
        {
            int Option;
            do
            {
                Console.WriteLine("Select from the following:\n1.Medicine List\n2.Purchase Medicine\n3.Cancel Purchase\n4.Purchase History\n5.Recharge\n6.Wallet Balance\n7.Exit");
                Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        {
                            MedicineList();
                            break;
                        }
                    case 2:
                        {
                            PurchaseMedicine();
                            break;
                        }
                    case 3:
                        {
                            CancelPurchase();
                            break;
                        }
                    case 4:
                        {
                            PurchaseHistory();
                            break;
                        }
                    case 5:
                        {
                            Recharge();
                            break;
                        }
                    case 6:
                        {
                            WalletBalance();
                            break;
                        }
                }
            } while (Option < 7);
        }
        public void MedicineList()
        {
            foreach (MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.ExpiryDate}");
            }
        }
        public void PurchaseMedicine()
        {
            foreach (MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"{medicine.MedicineID}|{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.ExpiryDate}");
            }
            bool flag1 = true;
            Console.WriteLine("Enter the medicine ID: ");
            string medicineID = Console.ReadLine();
            foreach (MedicineDetails medicine in medicineList)
            {
                if (medicineID == medicine.MedicineID)
                {
                    flag1 = false;
                    Console.WriteLine("Enter the count of medicine: ");
                    int count = int.Parse(Console.ReadLine());
                    if (count <= medicine.AvailableCount)
                    {
                        if (medicine.ExpiryDate >= DateTime.Now)
                        {
                            Double TotalPrice = medicine.Price * count;
                            if (currentUser.Balance >= TotalPrice)
                            {
                                medicine.AvailableCount -= count;
                                currentUser.Balance -= TotalPrice;
                                OrderDetails orderDetails = new OrderDetails(userID, medicineID, medicineCount, totalPrice, DateTime.Now, OrderStatus.Purchased);
                                orderList.Add(orderDetails);
                                Console.WriteLine($"Medicine was purchased successfully.Your total amount:{TotalPrice},Order Date:{DateTime.Now}");
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough balance to purchase");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Medicine not available");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Out of stock");
                    }

                }
            }
            if (flag1)
            {
                Console.WriteLine("Invalid Medicine ID!");
            }

        }
        public void CancelPurchase()
        {
            Console.WriteLine("Enter your Customer ID: ");
            string customerID = Console.ReadLine();
            foreach (UserDetails user in userList)
            {
                if (customerID == user.UserID)
                {
                    Console.WriteLine($"{user.UserName}|{user.Age}|{user.City}|{user.Phone}|{user.Balance}");
                }
            }
            Console.WriteLine("Enter your OrderID: ");
            string orderID = Console.ReadLine();
            foreach (OrderDetails order in orderList)
            {
                if (orderID == order.OrderID && OrderStatus.Purchased == order.Status)
                {
                    foreach (MedicineDetails medicine in medicineList)
                    {
                        medicine.AvailableCount += medicineCount;
                        currentUser.Balance += totalPrice;
                    }
                    order.Status = OrderStatus.Cancelled;
                }
            }

            Console.WriteLine("Your Order Successfully Cancelled!");

        }
        public void PurchaseHistory()
        {
            Console.WriteLine("Enter your Order ID: ");
            string orderID = Console.ReadLine();
            foreach (OrderDetails order in orderList)
            {
                if (orderID == order.OrderID)
                {
                    Console.WriteLine($"{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate}|{order.Status}");
                }
            }
        }
        public void Recharge()
        {
            Console.WriteLine("Enter the amount to be recharged: ");
            double amount = double.Parse(Console.ReadLine());
            double FinalBalance = currentUser.RechargeBalance(amount);
            Console.WriteLine(FinalBalance);
        }
        public void WalletBalance()
        {
            Console.WriteLine(currentUser.Balance);
        }

    }
}