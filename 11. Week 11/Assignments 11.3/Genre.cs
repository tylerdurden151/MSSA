using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignments_11._3
{
    internal class Genre
    {
        public int GenreId { get; set; }
        public string? Name { get; set; }

        public virtual ObservableCollectionListSource<Movie> Movies { get; } = new();
    }
}
