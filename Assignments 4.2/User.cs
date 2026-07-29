using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_4._2
{
    internal abstract class User
    {
        public string UserName { get; set; } = "";
        protected string _password = Guid.NewGuid().ToString(); // Generate a random password by default
        public string Password { 
            set {
                if (!SetPassword(value))
                {
                throw  new ArgumentException("Password not complex enough", "Password");
                }
                _password = value;
            } 
        }
        public bool VerifyPassword(string password)
        {
            return (String.Compare(_password, password) == 0);
        }

        public abstract bool SetPassword(string password);

    }
}
