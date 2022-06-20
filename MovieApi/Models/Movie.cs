using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    // Each movie information consists of - Name, Date of Release, Producer, and all actors of the movie.
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Producer { get; set; }
        public string Cast { get; set; }
    }
}
