﻿using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Name = "Master of Puppets",
                    Year = 1985,
                    Rating = 5
                },

                new Song
                {
                    SongId = 2,
                    Name = "Wonderwall",
                    Year = 1990,
                    Rating = 3
                },

                new Song
                {
                    SongId = 3,
                    Name = "Lose Yourself",
                    Year = 2000,
                    Rating = 2
                }
                );
        }
    }
}