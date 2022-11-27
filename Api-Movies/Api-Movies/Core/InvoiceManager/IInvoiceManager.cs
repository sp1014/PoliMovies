using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.InvoiceManager
{
    public interface IInvoiceManager
    {
        Task<ResultHelper<IEnumerable<Invoice>>> GetInvoiceAsync();
        Task<ResultHelper<Invoice>> GetByIdAsync(int id);
        Task<ResultHelper<Invoice>> CreateInvoiceAsync(Invoice invoice);
    }
}
