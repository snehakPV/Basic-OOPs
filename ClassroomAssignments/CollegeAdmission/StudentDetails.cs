using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
        //field
        //creating static field for Auto increment ID
        private static int s_studentID=1000;

        //Properties
        
        /*
        //Properties with actual field working eg
        private string _studentName;
        public static StudentName{ get{return _studentName;} set{value = _studentName;}} //indepth view
        */

        //Auto property
        public string StudentID { get;}
        public string StudentName{get;set;}
        public string FatherName{get;set;}
        public DateTime DOB{get;set;}
        public Gender StudentGender{get;set;}
        public long Phone{get;set;}
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}

        //constructor
        //default constructor
        public StudentDetails()
        {
            StudentName="Enter your name";
            FatherName="Enter your Father name";
        }
        //Parameterized constructor
        public StudentDetails(string studentName,string fatherName,DateTime dob,Gender studentGender,long phone,int physics,int chemistry,int maths)
        {
            //increment ID and assign to property
            s_studentID++;
            StudentID="SID"+s_studentID;
            //Assigning parameter to properties
             StudentName=studentName;
             FatherName=fatherName;
             DOB=dob;
             StudentGender=studentGender;
             Phone=phone;
             Physics=physics;
             Chemistry=chemistry;
             Maths=maths;

        }
        //constructor overloading -- adding additional constructor which differs by the parameters passed in it.
        public StudentDetails(string studentName,string fatherName,long phone)
        {
         StudentName = studentName;
         FatherName = fatherName;
         Phone = phone;
        }
        //Destructor
        ~StudentDetails()
        {

        }
        //method
        public bool CheckEligibility(double cutoff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3;
            if(average >= cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}