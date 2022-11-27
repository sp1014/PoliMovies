using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.ColectionsManager
{
    public class ColectionsManager : IColectionsManager
    {
        private readonly UsersContext _context;

        public ColectionsManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Colections>>> GetColectionsAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Colections>>();
            var users = await _context.Colectionses.ToListAsync();

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

        public async Task<ResultHelper<Colections>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Colections>();
            var user = await _context.Colectionses.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Colections>> CreateColectionsAsync(Colections colections)
        {
            var resultado = new ResultHelper<Colections>();
            try
            {
                Colections nuevaRol = new Colections

                {
                   Name = colections.Name
                };
                _context.Colectionses.Add(nuevaRol);
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
