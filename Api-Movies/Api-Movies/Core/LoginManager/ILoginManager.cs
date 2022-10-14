using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.LoginManager
{
    public interface ILoginManager
    {
        /// <summary>
        /// In this asynchronous operation, the Result Helper class is called to obtain the user  model.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ResultHelper<User>> LoginAsync(User user);
        /// <summary>
        /// In this asynchronous operation, the Result Helper class is called to obtain the id  model.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<User>> GetByIdAsync(int id);
    }
}
