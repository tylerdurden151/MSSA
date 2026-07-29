using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_4._2
{
    internal class Teacher : User
    {
        public Subject Subject { get; set; }

        public Teacher(string userName, Subject subject)
        {
            UserName = userName;
            Subject = subject;
        }
        public override bool SetPassword(string password)
        {
            // Example implementation - you can customize this as needed
            return password.Length >= 8;
        }
    }
}