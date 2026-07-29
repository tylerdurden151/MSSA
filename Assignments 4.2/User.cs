using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_4._2
{
    internal abstract class User
    {
        public string UserName { get; set; }
        protected string _password = Guid.NewGuid().ToString(); // Generate a random password by default
        public string Password { set { if (!SetPassord(value))
                {
                throw  new ArgumentException("Password not complex enough", "Password");
                }
            } 
        }
        public bool VerifyPassword(string password)
        {
            return (String.Compare(_password, password) == 0);
        }

        public abstract bool SetPassord(string password);

    }
}
