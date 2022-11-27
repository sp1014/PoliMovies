using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.FileManager
{
    public interface IFileManager
    {
   
        Task<ResultHelper<IEnumerable<File>>> GetFilesAsync();
        Task<ResultHelper<File>> GetByIdAsync(int id);
       
    }
}
