using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Assignments_11._3
{
    internal class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=movies.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Comedy" },
                new Genre { GenreId = 2, Name = "Action" },
                new Genre { GenreId = 3, Name = "Sci-Fi" },
                new Genre { GenreId = 4, Name = "Drama" });

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, GenreId = 1, Title = "Superbad" },
                new Movie { MovieId = 2, GenreId = 1, Title = "Anchorman" },
                new Movie { MovieId = 3, GenreId = 1, Title = "Step Brothers" },
                new Movie { MovieId = 4, GenreId = 2, Title = "Die Hard" },
                new Movie { MovieId = 5, GenreId = 2, Title = "Mad Max: Fury Road" },
                new Movie { MovieId = 6, GenreId = 2, Title = "John Wick" },
                new Movie { MovieId = 7, GenreId = 3, Title = "The Matrix" },
                new Movie { MovieId = 8, GenreId = 3, Title = "Interstellar" },
                new Movie { MovieId = 9, GenreId = 3, Title = "Dune" },
                new Movie { MovieId = 10, GenreId = 4, Title = "The Godfather" },
                new Movie { MovieId = 11, GenreId = 4, Title = "Forrest Gump" },
                new Movie { MovieId = 12, GenreId = 4, Title = "Whiplash" });

        }
    }
}
