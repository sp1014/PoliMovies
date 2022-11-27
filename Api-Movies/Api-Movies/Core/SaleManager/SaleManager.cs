using Api_Movies;
using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Movies.Core.SaleManager
{
    public class SaleManager : ISaleManager
    {
        private readonly UsersContext _context;

        public SaleManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Sale>>> GetSalesAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Sale>>();
            var users = await _context.Sales.ToListAsync();

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

        public async Task<ResultHelper<Sale>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Sale>();
            var user = await _context.Sales.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Sale>> CreateSalesAsync(Sale sale)
        {
            var resultado = new ResultHelper<Sale>();
            try
            {
                Sale nuevaRol = new Sale

                {
                    date = sale.date,
                    totalPrice = sale.totalPrice,
                    quantity = sale.quantity

                };
                _context.Sales.Add(nuevaRol);
                await _context.SaveChangesAsync();
                resultado.Value = nuevaRol;
            }
            catch (Exception e)
            {
                resultado.AddError(e.Message);
            }
            return resultado;
        }

        //Detail Sale
        public async Task<ResultHelper<IEnumerable<DetailSale>>> GetSalesDetailAsync()
        {
            var resultado = new ResultHelper<IEnumerable<DetailSale>>();
            var users = await _context.DetailSales.ToListAsync();

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

        public async Task<ResultHelper<DetailSale>> GetByIdDetailAsync(int id)
        {
            var resultado = new ResultHelper<DetailSale>();
            var user = await _context.DetailSales.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<DetailSale>> CreateSalesDetailAsync(DetailSale detailSale)
        {
            var resultado = new ResultHelper<DetailSale>();
            try
            {
                DetailSale nuevaRol = new DetailSale

                {
                   Detail = detailSale.Detail,  
                   IdUser = detailSale.IdUser,
                   IdSale = detailSale.IdSale

                };
                _context.DetailSales.Add(nuevaRol);
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
