using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.IdiomManager
{
    public interface IIdiomManager
    {
        Task<ResultHelper<IEnumerable<Idiom>>> GetIdiomsAsync();
        Task<ResultHelper<Idiom>> GetByIdAsync(int id);
        Task<ResultHelper<Idiom>> CreateIdiomsAsync(Idiom idiom);
    }
}
