using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_4._2
{
    internal static class Session
    {
        public static Teacher CurrentTeacher { get; private set; }

        public static bool IsLoggedIn => CurrentTeacher != null;

        public static void StartSession(Teacher teacher)
        {
            CurrentTeacher = teacher;
        }

        public static void ClearSession()
        {
            CurrentTeacher = null;
        }
    }
}
