/*Design a personal phone /address book using Dictionary collection. 
 * 
 * Write a person class to store details of person like : FirstName , LastName , Mobile Phone , Work Phone and Address.
Provide a grid to display all, add more, delete ( with confirmation message) and search by name.

Search should show details of person searched. You may use the key as name of person.
 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4._1
{
    internal class Person
    {
        private string _name;
        private string _lastName;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                _lastName = value;
            }
        }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string WorkNumber { get; set; }
        public string HomeNumber { get; set; }

    }
}
