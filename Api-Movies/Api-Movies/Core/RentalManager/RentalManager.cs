using Api_Movies;
using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Core.RentalManager
{
    public class RentalManager : IRentalManager
    {
        private readonly UsersContext _context;

        public RentalManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Rental>>> GetRentalsAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Rental>>();
            var users = await _context.Rentales.ToListAsync();

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

        public async Task<ResultHelper<Rental>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Rental>();
            var user = await _context.Rentales.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Rental>> CreateRentalAsync(Rental rental)
        {
            var resultado = new ResultHelper<Rental>();
            try
            {
                Rental nuevaRol = new Rental

                {
                   NameProduct = rental.NameProduct,
                   Quantity = rental.Quantity,
                   PriceRental = rental.PriceRental,
                   DateInitRental = rental.DateInitRental,
                   DateEndRental = rental.DateEndRental
                };
                _context.Rentales.Add(nuevaRol);
                await _context.SaveChangesAsync();
                resultado.Value = nuevaRol;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }

        public async Task<ResultHelper<IEnumerable<DetailRental>>> GetRentalsDetailAsync()
        {
            var resultado = new ResultHelper<IEnumerable<DetailRental>>();
            var users = await _context.DetailRentales.ToListAsync();

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
        public async Task<ResultHelper<DetailRental>> GetByIdDetailAsync(int id)
        {
            var resultado = new ResultHelper<DetailRental>();
            var user = await _context.DetailRentales.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<DetailRental>> CreateRentalDetailAsync(DetailRental detailRental)
        {
            var resultado = new ResultHelper<DetailRental>();
            try
            {
                DetailRental nuevaRol = new DetailRental

                {
                    Detail = detailRental.Detail,
                    IdUser = detailRental.IdUser,
                    IdRental = detailRental.IdRental
   
                 };
                _context.DetailRentales.Add(nuevaRol);
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
