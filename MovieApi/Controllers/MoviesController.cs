using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Repositories;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _movieRepository.Get();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovies(int id)
        {
            return await _movieRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovies([FromBody] Movie movie)
        {
            var newMovie = await _movieRepository.Create(movie);
            return CreatedAtAction(nameof(GetMovies), new { id = newMovie.Id }, newMovie);
        }

        [HttpPut]
        public async Task<ActionResult> PutBooks(int id, [FromBody] Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            await _movieRepository.Update(movie);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookToDelete = await _movieRepository.Get(id);
            if (bookToDelete == null)
                return NotFound();

            await _movieRepository.Delete(bookToDelete.Id);
            return NoContent();
        }


    }

}


    