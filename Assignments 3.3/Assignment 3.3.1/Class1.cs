using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._3._1
{
    internal class Student
    {
        private int _studId;
        private char _grade;
        public int StudId { get { return _studId; } set { _studId = value; } }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public string MonthOfAdmission { get; set; } = "";
        public char Grade { get { return _grade; } set { _grade = value; }  }
    }
}