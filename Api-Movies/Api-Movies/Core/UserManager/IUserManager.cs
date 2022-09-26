using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.UserManager
{
    public interface IUserManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResultHelper<IEnumerable<User>>> GetUsersAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<User>> GetByIdAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ResultHelper<User>> CreateAsync(User user);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<User>> UpdateAsync(User user, int id);


    }
}