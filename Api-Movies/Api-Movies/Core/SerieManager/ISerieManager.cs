using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.SerieManager
{
    public interface ISerieManager
    {
        Task<ResultHelper<IEnumerable<Serie>>> GetSeriesAsync();
        Task<ResultHelper<Serie>> GetByIdAsync(int id);
        Task<ResultHelper<Serie>> CreateSeriesAsync(Serie serie);
    }
}
