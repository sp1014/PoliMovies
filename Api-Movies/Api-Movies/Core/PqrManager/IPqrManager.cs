using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.PqrManager
{
    public interface IPqrManager
    {
        Task<ResultHelper<IEnumerable<Pqr>>> GetPqrsAsync();
        Task<ResultHelper<Pqr>> GetByIdAsync(int id);
        Task<ResultHelper<Pqr>> CreatePqrsAsync(Pqr pqr);
    }
}
