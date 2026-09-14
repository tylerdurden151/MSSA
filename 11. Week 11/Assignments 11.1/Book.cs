using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;

namespace Assignments_11._1
{
    internal class Book
    {
        [Key]
        public int ISBN { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }

    }
}
