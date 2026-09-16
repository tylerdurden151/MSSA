using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_11._3
{
    internal class Movie
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; } = null!;
    }
}
