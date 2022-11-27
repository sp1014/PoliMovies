

using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Api_Movies.Core.IdiomManager
{
    public class IdiomManager : IIdiomManager
    {
        private readonly UsersContext _context;

        public IdiomManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Idiom>>> GetIdiomsAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Idiom>>();
            var users = await _context.Idioms.ToListAsync();

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

        public async Task<ResultHelper<Idiom>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Idiom>();
            var user = await _context.Idioms.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Idiom>> CreateIdiomsAsync(Idiom idiom)
        {
            var resultado = new ResultHelper<Idiom>();
            try
            {
                Idiom nuevaRol = new Idiom

                {

                 Lenguage  = idiom.Lenguage,
                 SubTitle = idiom.SubTitle,
                 Doblaje = idiom.Doblaje,
                 IdMovie = idiom.IdMovie
                 };

                _context.Idioms.Add(nuevaRol);
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
