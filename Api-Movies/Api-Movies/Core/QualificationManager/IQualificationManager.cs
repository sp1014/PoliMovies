using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.QualificationManager
{
    public interface IQualificationManager
    {
        Task<ResultHelper<IEnumerable<Qualification>>> GetQualificationsAsync();
        Task<ResultHelper<Qualification>> GetByIdAsync(int id);
        Task<ResultHelper<Qualification>> CreateQualificationsAsync(Qualification qualification);
    }
}
