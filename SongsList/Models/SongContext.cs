using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsList.Models
{
    public class SongContext : DbContext
    {
        // Pass the options to the base class
        public SongContext(DbContextOptions<SongContext> options)
            :base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "M", Name = "Metal" },
                new Genre { GenreId = "R", Name = "Rap" },
                new Genre { GenreId = "H", Name = "Hip Hop" },
                new Genre { GenreId = "RC", Name = "Rock" },
                new Genre { GenreId = "P", Name = "Pop" }
                );

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Name = "Master of Puppets",
                    Year = 1985,
                    Rating = 5,
                    GenreId = "M"
                },

                new Song
                {
                    SongId = 2,
                    Name = "Wonderwall",
                    Year = 1990,
                    Rating = 3,
                    GenreId = "RC"
                },

                 new Song
                 {
                     SongId = 3,
                     Name = "Three",
                     Year = 2010,
                     Rating = 5,
                     GenreId = "P"
                 },

                new Song
                {
                    SongId = 4,
                    Name = "Lose Yourself",
                    Year = 2000,
                    Rating = 2,
                    GenreId = "R"
                }
                );
        }
    }
}
