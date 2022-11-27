using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.CategoryManager
{
    public interface ICategoryManager
    {
        Task<ResultHelper<IEnumerable<Category>>> GetCategoryAsync();
        Task<ResultHelper<Category>> GetByIdAsync(int id);
        Task<ResultHelper<Category>> CreateCategoryAsync(Category category);
    }
}
