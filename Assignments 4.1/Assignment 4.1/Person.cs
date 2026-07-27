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
    internal abstract class Person
    {
        private string name;
        private string lastName;
        public Address address;
        public PhoneNumber phoneNumber1;
        public PhoneNumber phoneNumber2;
        public PhoneNumber phoneNumber3;

    }
}
