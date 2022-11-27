using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.QualificationManager
{
    public class QualificationManager : IQualificationManager
    {
        private readonly UsersContext _context;

        public QualificationManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Qualification>>> GetQualificationsAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Qualification>>();
            var users = await _context.Qualifications.ToListAsync();

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

        public async Task<ResultHelper<Qualification>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Qualification>();
            var user = await _context.Qualifications.FirstOrDefaultAsync(s => s.Id == id);
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
        public async Task<ResultHelper<Qualification>> CreateQualificationsAsync(Qualification qualification)
        {
            var resultado = new ResultHelper<Qualification>();
            try
            {
                Qualification nuevaRol = new Qualification

                {
                    Qualifications = qualification.Qualifications,
                    Commentary = qualification.Commentary,
                };
                _context.Qualifications.Add(nuevaRol);
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