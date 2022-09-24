using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.LoginManager
{
    public interface ILoginManager
    {
        Task<ResultHelper<User>> LoginAsync(User user);
        Task<ResultHelper<User>> GetByIdAsync(int id);
    }
}
