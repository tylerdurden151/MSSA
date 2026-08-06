using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4._1
{
    internal class PhoneBook
    {
        private Dictionary<string, Person> _phoneBook;


        public PhoneBook()
        {
            _phoneBook = new Dictionary<string, Person>();
        }

        // Add a person to the phone book
        // person is the object of the Person class that contains the person's information
        public void AddPerson(Person person)
        {
            string key = $"{person.Name} {person.LastName}";
            _phoneBook[key] = person;
        }

        public bool DeletePerson(string name)
        {
            return _phoneBook.Remove(name);
        }

        public Person SearchPerson(string name)
        {
            return _phoneBook.ContainsKey(name) ? _phoneBook[name] : null;
        }
    }
}
