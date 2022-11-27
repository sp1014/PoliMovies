using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.SerieManager
{
    public class SerieManager : ISerieManager
    {
        private readonly UsersContext _context;

        public SerieManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Serie>>> GetSeriesAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Serie>>();
            var users = await _context.Series.ToListAsync();

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
        public async Task<ResultHelper<Serie>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Serie>();
            var user = await _context.Series.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Serie>> CreateSeriesAsync(Serie serie)
        {
            var resultado = new ResultHelper<Serie>();
            try
            {
                Serie nuevaRol = new Serie

                {
                  Name = serie.Name,
                  season = serie.season
                };
                _context.Series.Add(nuevaRol);
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
