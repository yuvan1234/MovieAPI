﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MovieApi.Models
{

    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
          : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
