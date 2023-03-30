using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public enum Gender{Select,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_studentID=3000;
        public string StudentID { get; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender StudentGender{get;set;}
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public StudentDetails(string studentName,string fatherName,DateTime dob,Gender studentGender,int physics,int chemistry,int maths)
        {
         s_studentID++;
         StudentID="SF"+s_studentID;
         StudentName=studentName;
         FatherName=fatherName;
         DOB=dob;
         StudentGender=studentGender;
         Physics=physics;
         Chemistry=chemistry;
         Maths=maths;
        }
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