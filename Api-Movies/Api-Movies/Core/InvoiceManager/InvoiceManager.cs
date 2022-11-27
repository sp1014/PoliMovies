using Api_Movies.Helpers;
using Api_Movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.InvoiceManager
{
    public class InvoiceManager : IInvoiceManager
    {
        private readonly UsersContext _context;

        public InvoiceManager(UsersContext context)
        {
            _context = context;
        }
        private const string _ERROR_USER = "this data does not exist";
        private const string _ERROR_EMAIL = "Email already exists";
        private const string _ERROR_LIST = "There is no user at this time";

        public async Task<ResultHelper<IEnumerable<Invoice>>> GetInvoiceAsync()
        {
            var resultado = new ResultHelper<IEnumerable<Invoice>>();
            var users = await _context.Invoices.ToListAsync();

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

        public async Task<ResultHelper<Invoice>> GetByIdAsync(int id)
        {
            var resultado = new ResultHelper<Invoice>();
            var user = await _context.Invoices.FirstOrDefaultAsync(s => s.Id == id);
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

        public async Task<ResultHelper<Invoice>> CreateInvoiceAsync(Invoice invoice)
        {
            var resultado = new ResultHelper<Invoice>();
            try
            {
                Invoice nuevaRol = new Invoice

                {
                   status = invoice.status
                };
                _context.Invoices.Add(nuevaRol);
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
