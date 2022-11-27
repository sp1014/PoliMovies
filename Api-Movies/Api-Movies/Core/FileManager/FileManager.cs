
using Api_Movies;
using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Api_Movies.Core.FileManager
{
    public class FileManager :  IFileManager
    {
        private readonly UsersContext _context;

        public FileManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<File>>> GetFilesAsync()
        {
            var resultado = new ResultHelper<IEnumerable<File>>();
            var users = await _context.Files.ToListAsync();

            if (users.Count > 0)
            {
                resultado.Value = users;
            }
            else
            {
                string error = _ERROR_LIST;
                resultado.AddError(error);
            }
            return resultado;
        }
        public async Task<ResultHelper<File>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<File>();
            var user = await _context.Files.FirstOrDefaultAsync(s => s.Id == id);
            if (user != null)
            {
                resultado.Value = user;
            }
            else
            {
                string error = _ERROR_USER;
                resultado.AddError(error);
            }
            return resultado;
        }
    }
}

