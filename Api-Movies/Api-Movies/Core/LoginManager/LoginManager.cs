using Api_Movies;
using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Api_Movies.Core.LoginManager
{
 
    public class LoginManager : ILoginManager
    {
        private readonly UsersContext _context;

        public LoginManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_USER = "this data does not exist";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResultHelper<User>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<User>();
            var user = await _context.Users.FirstOrDefaultAsync(s => s.Id == id);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ResultHelper<User>> LoginAsync(User user)
        {
            var resultado = new ResultHelper<User>();

            try
            {
                User nuevaUser = new User
                {

                    Email = user.Email,
                    Password = user.Password = Encrypt.GetSHA256(user.Password)

                };
                var vali = (from d in _context.Users
                            where d.Email == user.Email && d.Password == user.Password
                            select d).FirstOrDefault();
                if (vali != null)
                {
                    _context.Users.Add(nuevaUser);

                    resultado.Value = vali;
                }
                else
                {
                    string error = _ERROR_EMAIL;
                    resultado.AddError(error);
                }
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }
    }
    }
