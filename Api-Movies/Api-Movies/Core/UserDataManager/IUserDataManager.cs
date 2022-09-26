using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.UserDataManager
{
    public interface IUserDataManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResultHelper<IEnumerable<Rol>>> GetUsersDataAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<Rol>> GetByIdAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        Task<ResultHelper<Rol>> CreateRolAsync(Rol rol);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<Rol>> UpdateRolAsync(Rol rol, int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResultHelper<IEnumerable<TypeDoc>>> GetUsersDocAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<TypeDoc>> GetByIdDocAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeDoc"></param>
        /// <returns></returns>
        Task<ResultHelper<TypeDoc>> CreateDocAsync(TypeDoc typeDoc);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeDoc"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultHelper<TypeDoc>> UpdateDocAsync(TypeDoc typeDoc, int id);
    }
}