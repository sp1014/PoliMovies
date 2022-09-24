using Api_Movies;
using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Api_Movies.Core.UserDataManager;
namespace Api_Movies.Core.UserDataManager
{
    public class UserDataManager : IUserDataManager
    {
        private readonly UsersContext _context;

        public UserDataManager(UsersContext context)
        {
            _context = context;
        }

        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";
        public async Task<ResultHelper<IEnumerable<Rol>>> GetUsersDataAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Rol>>();
            var roles = await _context.Roles.ToListAsync();

            if (roles.Count > 0)
            {
                resultado.Value = roles;
            }
            else
            {
                string error = _ERROR_LIST;
                resultado.AddError(error);
            }
            return resultado;
        }

        public async Task<ResultHelper<Rol>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Rol>();
            var rol = await _context.Roles.FirstOrDefaultAsync(s => s.Id == id);
            if (rol != null)
            {
                resultado.Value = rol;
            }
            else
            {
                string error = _ERROR_USER;
                resultado.AddError(error);
            }
            return resultado;
        }


        public async Task<ResultHelper<Rol>> CreateRolAsync(Rol rol)
        {
            var resultado = new ResultHelper<Rol>();
            try
            {
                Rol nuevaRol = new Rol

                {
                    NameRole = rol.NameRole,
                };           
                    _context.Roles.Add(nuevaRol);
                    await _context.SaveChangesAsync();
                    resultado.Value = nuevaRol;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }

     

              public async Task<ResultHelper<Rol>> UpdateRolAsync(Rol rol , int id)
        {
            var resultado = new ResultHelper<Rol>();
            try
            {
                if (id == rol.Id)
                {
                    Rol nuevaRol = new Rol

                    {
                        Id = rol.Id,
                        NameRole = rol.NameRole,
                    };
                    _context.Entry(nuevaRol).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    resultado.Value = nuevaRol;
                }
                else
                {
                    resultado.AddError("El id no coincide con el id del Rol");
                }
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }

        //Type Document

        public async Task<ResultHelper<IEnumerable<TypeDoc>>> GetUsersDocAsync()
        {
            var resultado = new ResultHelper<IEnumerable<TypeDoc>>();
            var doc = await _context.TypeDocs.ToListAsync();

            if (doc.Count > 0)
            {
                resultado.Value = doc;
            }
            else
            {
                string error = _ERROR_LIST;
                resultado.AddError(error);
            }
            return resultado;
        }

        public async Task<ResultHelper<TypeDoc>> GetByIdDocAsync(int id)
        {
            var resultado = new ResultHelper<TypeDoc>();
            var doc = await _context.TypeDocs.FirstOrDefaultAsync(s => s.Id == id);
            if (doc != null)
            {
                resultado.Value = doc;
            }
            else
            {
                string error = _ERROR_USER;
                resultado.AddError(error);
            }
            return resultado;
        }

        public async Task<ResultHelper<TypeDoc>> CreateDocAsync(TypeDoc typedoc)
        {
            var resultado = new ResultHelper<TypeDoc>();
            try
            {
                TypeDoc nuevaDoc = new TypeDoc

                {
                    NameTypeDoc = typedoc.NameTypeDoc,
                };
                _context.TypeDocs.Add(nuevaDoc);
                await _context.SaveChangesAsync();
                resultado.Value = nuevaDoc;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }

        public async Task<ResultHelper<TypeDoc>> UpdateDocAsync(TypeDoc typedoc, int id)
        {
            var resultado = new ResultHelper<TypeDoc>();
            try
            {
                if (id == typedoc.Id)
                {
                    TypeDoc nuevoDoc = new TypeDoc

                    {
                        Id = typedoc.Id,
                        NameTypeDoc = typedoc.NameTypeDoc,
                    };
                    _context.Entry(nuevoDoc).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    resultado.Value = nuevoDoc;
                }
                else
                {
                    resultado.AddError("El id no coincide con el id del Doc");
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


  
