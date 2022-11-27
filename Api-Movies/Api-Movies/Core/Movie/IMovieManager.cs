using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.MovieManager
{
    public interface IMovieManager
    {
        Task<ResultHelper<IEnumerable<Movie>>> GetMoviesAsync();
        Task<ResultHelper<Movie>> GetByIdAsync(int id);
        Task<ResultHelper<Movie>> CreateAsync(Movie movie);
    }
}
