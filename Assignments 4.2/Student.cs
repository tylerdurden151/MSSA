using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_4._2
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
        public Subject StudentSubject { get; set; }

        public double GPA { get; set; }
        public Student(int studentId, string studentName, Subject studentSubject, double gpa)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentSubject = studentSubject;
            GPA = gpa;
        }
    }
}
