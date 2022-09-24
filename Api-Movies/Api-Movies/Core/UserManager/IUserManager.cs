using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.UserManager
{
    public interface IUserManager
    {
        Task<ResultHelper<IEnumerable<User>>> GetUsersAsync();
        Task<ResultHelper<User>> GetByIdAsync(int id);
        Task<ResultHelper<User>> CreateAsync(User user);
        Task<ResultHelper<User>> UpdateAsync(User user, int id);
        // Task<ResultHelper<User>> GetByIdListAsync(int id);


    }
}