using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Api_Movies.Core.PqrManager
{
    public class PqrManager : IPqrManager
    {
        private readonly UsersContext _context;

        public PqrManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Pqr>>> GetPqrsAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Pqr>>();
            var users = await _context.Pqrs.ToListAsync();

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

        public async Task<ResultHelper<Pqr>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Pqr>();
            var user = await _context.Pqrs.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Pqr>> CreatePqrsAsync(Pqr pqr)
        {
            var resultado = new ResultHelper<Pqr>();
            try
            {
                Pqr nuevaRol = new Pqr

                {
                    Description = pqr.Description,
                    date = pqr.date,
                    IdUser = pqr.IdUser

                };
                _context.Pqrs.Add(nuevaRol);
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
