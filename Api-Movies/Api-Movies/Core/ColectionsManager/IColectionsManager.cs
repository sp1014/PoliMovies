using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.ColectionsManager
{
    public interface IColectionsManager
    {
        Task<ResultHelper<IEnumerable<Colections>>> GetColectionsAsync();
        Task<ResultHelper<Colections>> GetByIdAsync(int id);
        Task<ResultHelper<Colections>> CreateColectionsAsync(Colections colections);
    }
}
