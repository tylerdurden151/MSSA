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
        public string address { get; set; }
        public int MobileNumber { get; set; }
        public int WorkNumber { get; set; }
        public int HomeNumber { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
