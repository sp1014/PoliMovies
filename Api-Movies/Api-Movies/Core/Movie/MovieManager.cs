using Api_Movies;
using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Api_Movies.Core.MovieManager;

namespace Api_Movies.Core.MovieManager
{
    public class MovieManager : IMovieManager
    {
        private readonly UsersContext _context;
        public MovieManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Movie>>> GetMoviesAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Movie>>();
            var users = await _context.Movies.ToListAsync();

            if (users.Count > 0)
            {
                resultado.Value = users;
            }
            else
            {
                string error = _ERROR_LIST;
                resultado.AddError(error);
            }
            return resultado;
        }
        public async Task<ResultHelper<Movie>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Movie>();
            var user = await _context.Movies.FirstOrDefaultAsync(s => s.Id == id);
            if (user != null)
            {
                resultado.Value = user;
            }
            else
            {
                string error = _ERROR_USER;
                resultado.AddError(error);
            }
            return resultado;
        }
        public async Task<ResultHelper<Movie>> CreateAsync(Movie movie)
        {
            var resultado = new ResultHelper<Movie>();
            try
            {
                Movie nueva = new Movie

                {

                    TitleMovie = movie.TitleMovie,
                    DateProduction = movie.DateProduction,
                    Duration = movie.Duration,
                    Actors = movie.Actors,
                    Directors = movie.Directors,
                    Producers = movie.Producers,
                    IdRental = movie.IdRental,
                    IdSale = movie.IdSale,
                    IdQualification = movie.IdQualification,
                    IdSerie = movie.IdSerie,
                    IdFile = movie.IdFile,
                    IdColections = movie.IdColections,

                };

                _context.Movies.Add(nueva);
                await _context.SaveChangesAsync();
                resultado.Value = nueva;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }
    }
}
