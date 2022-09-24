using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.UserDataManager
{
    public interface IUserDataManager
    {
        Task<ResultHelper<IEnumerable<Rol>>> GetUsersDataAsync();
        Task<ResultHelper<Rol>> GetByIdAsync(int id);
        Task<ResultHelper<Rol>> CreateRolAsync(Rol rol);
        Task<ResultHelper<Rol>> UpdateRolAsync(Rol rol, int id);

        Task<ResultHelper<IEnumerable<TypeDoc>>> GetUsersDocAsync();
        Task<ResultHelper<TypeDoc>> GetByIdDocAsync(int id);
        Task<ResultHelper<TypeDoc>> CreateDocAsync(TypeDoc typeDoc);
        Task<ResultHelper<TypeDoc>> UpdateDocAsync(TypeDoc typeDoc, int id);
        
        // Task<ResultHelper<User>> LoginAsync(User user);
        //Task<ResultHelper<User>> UpdateAsync(User user, int id);
        // Task<ResultHelper<User>> GetByIdListAsync(int id);


    }
}