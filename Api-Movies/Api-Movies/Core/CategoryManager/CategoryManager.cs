using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.CategoryManager
{
    public class CategoryManager : ICategoryManager
    {
        private readonly UsersContext _context;

        public CategoryManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Category>>> GetCategoryAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Category>>();
            var users = await _context.Categories.ToListAsync();

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
        public async Task<ResultHelper<Category>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Category>();
            var user = await _context.Categories.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Category>> CreateCategoryAsync(Category category)
        {
            var resultado = new ResultHelper<Category>();
            try
            {
                Category nuevaRol = new Category

                {
                   NameCategory = category.NameCategory,
                   IdMovie = category.IdMovie
                };
                _context.Categories.Add(nuevaRol);
                await _context.SaveChangesAsync();
                resultado.Value = nuevaRol;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }

    }
}
