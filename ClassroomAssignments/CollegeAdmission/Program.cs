using System;
using System.Collections.Generic;
namespace CollegeAdmission
{
    //Enum declaration
    public enum Gender{Default,Male,Female,Transgender}
    class Program
    {
        public static void Main(string[] args)
        {

            //List creation for storing the objects
            List<StudentDetails> studentList = new List<StudentDetails>();
            string choice = string.Empty;
            //repeating the process for n num of students
            do
            {
                //getting the input format
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your Father name: ");
                string fatherName = Console.ReadLine();
                Console.WriteLine("Enter your DOB: ");
                DateTime dob;
                //exception handling for datetime
                bool temp=DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,System.Globalization.DateTimeStyles.None,out dob);
                while(!temp)
                {
                    Console.WriteLine("Entered wrong date. Enter again");
                    temp=DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,System.Globalization.DateTimeStyles.None,out dob);
                }
                Console.WriteLine("Enter your gender");
                Gender gender ;
                //exception handling for enum
                bool temp1= Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
                while(!temp1)
                {
                    Console.WriteLine("Entered wrong gender.Enter again.");
                    temp1= Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
                }
                Console.WriteLine("Enter your phone:");
                long phone = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter your maths mark");
                int maths = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your chemistry mark");
                int chemistry = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your physics mark");
                int physics = int.Parse(Console.ReadLine());
                //object creation
                //with parametrrized constructor
                StudentDetails student = new StudentDetails(name, fatherName, dob, gender, phone, physics, maths, chemistry);
                //Adding the object to list
                studentList.Add(student);
                //displaying student ID for login purpose
                Console.WriteLine($"Student added sucessfully.Student ID:{student.StudentID}");

                //creating next object
                //asking decision from user -- loop breaker
                Console.WriteLine("Do you want to add another student-yes/no");
                choice = Console.ReadLine().ToLower();
            } while (choice == "yes");
            //Asking user to login
            Console.WriteLine("Enter your student ID to login");
            string loginID = Console.ReadLine().ToUpper();
            //printing the objects in the list
            bool flag = true;//if flag is true ID is not found
            foreach (StudentDetails student1 in studentList)
            {
                //checking the login ID
                if (student1.StudentID == loginID)
                {
                    flag = false; //re-initializing flag to false 
                    Console.WriteLine($"name:{student1.StudentName}\nfather name:{student1.FatherName}\ngender:{student1.StudentGender}\ndob:{student1.DOB}\nphnum:{student1.Phone}\nChemistry mark:{student1.Chemistry}\nMaths mark:{student1.Maths}\nPhysics mark:{student1.Physics} ");
                    //check eligibility
                    bool eligibility = student1.CheckEligibility(75.0);
                    if (eligibility)
                    {
                        Console.WriteLine("You are eligible!");

                    }
                    else
                    {
                        Console.WriteLine("You are not eligible!");
                    }
                }

            }
            if (flag)
            {
                Console.WriteLine("Invalid student ID");
            }
            //Garabage collection process
            GC.Collect();
            GC.WaitForPendingFinalizers();


        }


        //object creation
        /*
            StudentDetails student=new StudentDetails();
            Console.WriteLine("Enter your name: ");
            student.StudentName=Console.ReadLine();
            Console.WriteLine("Enter your Father name: ");
            student.FatherName=Console.ReadLine();
            Console.WriteLine("Enter your gender: ");
            student.StudentGender=Console.ReadLine();
            Console.WriteLine("Enter your mobile number: ");
            student.Phone=long.Parse(Console.ReadLine());
            studentList.Add(student);
            */

        //
    }
}