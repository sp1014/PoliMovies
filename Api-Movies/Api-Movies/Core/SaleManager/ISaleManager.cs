using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.SaleManager
{
    public interface ISaleManager
    {
        Task<ResultHelper<IEnumerable<Sale>>> GetSalesAsync();
        Task<ResultHelper<Sale>> GetByIdAsync(int id); 
        Task<ResultHelper<Sale>> CreateSalesAsync(Sale sale);
        //Detail sales
        Task<ResultHelper<IEnumerable<DetailSale>>> GetSalesDetailAsync();
        Task<ResultHelper<DetailSale>> GetByIdDetailAsync(int id);
        Task<ResultHelper<DetailSale>> CreateSalesDetailAsync(DetailSale detailSale);
    }
}
