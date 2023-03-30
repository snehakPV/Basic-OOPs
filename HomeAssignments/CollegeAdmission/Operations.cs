using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class Operations
    {
        List<StudentDetails> studentList = new List<StudentDetails>();
        List<DepartmentDetails> departmentList=new List<DepartmentDetails>();
        List<AdmissionDetails> admissionList=new List<AdmissionDetails>();
        public StudentDetails currentStudent;
        public void MainMenu()
        {
            int option = 0;
             do
            {
            Console.WriteLine("Select from the following\n1.Registration\n2.Login\n3.Department wise seat availability\n4.Exit ");
            option = int.Parse(Console.ReadLine());
            switch (option)
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
        } while (option < 3);
        }
    
      void Registration()
        {
            Console.WriteLine("Enter your Name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter your Father name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter your DOB: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.WriteLine("Enter your Gender: ");
            Gender studentGender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.WriteLine("Enter your physics mark");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your chemistry mark");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your maths mark");
            int maths = int.Parse(Console.ReadLine());
            StudentDetails details = new StudentDetails(studentName,fatherName,dob,studentGender,physics,chemistry,maths);
            studentList.Add(details);
            Console.WriteLine("Registered Successfully!\nYour ID:" + details.StudentID);
        }
         void Login()
        {
         Console.WriteLine("Enter Student ID: ");
            string studentID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(StudentDetails student in studentList)
            {
                if(studentID==student.StudentID)
                {
                    Console.WriteLine("Login Successful!");
                    currentStudent=student;
                    flag=false;
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Student ID!");
            }
        }
        void SubMenu()
        {
          int option=0;
          do
          {
            Console.WriteLine("Select from the following:\n1.Check Eligibility\n2.Show Details\n3.Take Admission\n4.Cancel Admission\n5.Show Admission Details\n6.Exit");
            option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                 
                    bool eligibility=currentStudent.CheckEligibility(75.0);
                    if(eligibility)
                    {
                        Console.WriteLine("You are Eligible!");
                    }
                    else
                    {
                        Console.WriteLine("You are not Eligible!");
                    }

                   
                    break;
                }
                case 2:
                {
                    ShowDetails();
                    break;
                }
                case 3:
                {
                    TakeAdmission();
                    break;
                }
                case 4:
                {
                    CancelAdmission();
                    break;
                }
                case 5:
                {
                    ShowAdmissionDetails();
                    break;
                }
            }

          }while(option<6);
        }
        void ShowDetails()
        {
            Console.WriteLine("Name: "+currentStudent.StudentName);
            Console.WriteLine("Father Name: "+currentStudent.FatherName);
            Console.WriteLine("Date of Birth: "+currentStudent.DOB);
            Console.WriteLine("Gender: "+currentStudent.StudentGender);
            Console.WriteLine("Maths :"+currentStudent.Maths);
            Console.WriteLine("Physics: "+currentStudent.Physics);
            Console.WriteLine("Chemistry: "+currentStudent.Chemistry);

        }
         void TakeAdmission()
        {
         foreach(DepartmentDetails department in departmentList)
         {
          Console.WriteLine($"Department ID:{department.DepartmentID} | Department Name:{department.DepartmentName} | Number Of Seats{department.NumberOfSeats}"); 
         }
         Console.WriteLine("Choose a department: ");
         string departmentID=Console.ReadLine().ToUpper();
         bool flag=true;
          foreach(DepartmentDetails department in departmentList)
          {
            if(departmentID==department.DepartmentID)
            {
             flag=false;
             if(department.NumberOfSeats!=0)
             {
              if(currentStudent.CheckEligibility(75.0))
              {
                int count=0;
                foreach(AdmissionDetails admission in admissionList)
                {
                    if(currentStudent.StudentID==admission.StudentID && AdmissionStatus.Admitted==admission.Status)
                    {
                     count++;
                    }
                }
                if(count==0)
                {
                    department.NumberOfSeats--;
                    AdmissionDetails admissionDetails=new AdmissionDetails(currentStudent.StudentID,departmentID,DateTime.Now,AdmissionStatus.Admitted);
                    admissionList.Add(admissionDetails);
                    Console.WriteLine("Admission Taken Successfully!\nYour Admission ID: "+admissionDetails.AdmissionID);
                }
                else
                {
                    Console.WriteLine("Admission already taken!");
                }
              }
              else
              {
                Console.WriteLine("Not Eligible");
              }
             }
             else
             {
              Console.WriteLine("Seat not available");
             }
            }
          }
          if(flag)
          {
            Console.WriteLine("Invalid Department ID");
          }
        }
        void CancelAdmission()
        {
            bool flag=true;
         foreach(AdmissionDetails admission in admissionList)
         {
            if(currentStudent.StudentID==admission.StudentID && AdmissionStatus.Admitted==admission.Status)
            {
                flag=false;
             admission.Status=AdmissionStatus.Cancelled;
             foreach(DepartmentDetails department in departmentList)
             {
                if(admission.DepartmentID==department.DepartmentID)
                {
                 department.NumberOfSeats++;
                }
             }
             Console.WriteLine("Admission Cancelled Successfully!");
            }
         }
         if(flag)
         {
            Console.WriteLine("You have not taken any admission yet");
         }
        }
        void ShowAdmissionDetails()
        {
          foreach(AdmissionDetails admission in admissionList)
          {
            if(currentStudent.StudentID==admission.StudentID)
            {
            Console.WriteLine($"Admission ID{admission.AdmissionID}|Student ID{admission.StudentID}|Department ID{admission.DepartmentID}|Admission Date{admission.AdmissionDate}");
            }
          }
        }
       public void Default()
       {
        StudentDetails defaultStudent=new StudentDetails("Ravichandran","Ettaparajan",new DateTime(2019,11,11),Gender.Male,95,95,95);
        studentList.Add(defaultStudent);
        DepartmentDetails defaultDepartment1=new DepartmentDetails("EEE",29);
        DepartmentDetails defaultDepartment2=new DepartmentDetails("CSE",29);
        DepartmentDetails defaultDepartment3=new DepartmentDetails("MECH",30);
        DepartmentDetails defaultDepartment4=new DepartmentDetails("ECE",30);
        departmentList.Add(defaultDepartment1);
        departmentList.Add(defaultDepartment2);
        departmentList.Add(defaultDepartment3);
        departmentList.Add(defaultDepartment4);
        AdmissionDetails defaultAdmission=new AdmissionDetails("SF3001","DID101",new DateTime(2019,11,11),AdmissionStatus.Admitted);
        admissionList.Add(defaultAdmission);
       }
        }
}