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

        public void AddPerson(Person person)
        {
            _phoneBook[person.Name] = person;
        }

        public void DeletePerson(string name)
        {
            _phoneBook.Remove(name);
        }

        public Person SearchPerson(string name)
        {
            return _phoneBook.ContainsKey(name) ? _phoneBook[name] : null;
        }
    }
}
