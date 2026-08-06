using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignments_4._2
{
    internal static class DataSource
    {
        public static List<Teacher> Teachers { get; private set; }
        public static BindingList<Student> Students { get; private set; }

        public static void CreateData()
        {
            Teachers = new List<Teacher>
            {
                new Teacher("vallee", Subject.Math)   { Password = "password99" },
                new Teacher("waited", Subject.English){ Password = "password99" },
                new Teacher("newmanb", Subject.Science){ Password = "password99" }
            };

            Students = new BindingList<Student>
            {
                new Student(1, "Kevin Liu", Subject.Math, 3.8),
                new Student(2, "Martin Weber", Subject.English, 3.2),
                new Student(3, "George Li", Subject.Science, 3.95)
            };
        }
    }
}
