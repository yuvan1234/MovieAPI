using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Models;

namespace MovieApi.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> Get();
        Task<Movie> Get(int id);
        Task<Movie> Create(Movie movie);
        Task Update(Movie movie);
        Task Delete(int id);
    }
}
