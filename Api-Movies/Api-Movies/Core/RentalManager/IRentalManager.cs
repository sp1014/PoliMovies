using Api_Movies.Helpers;
using Api_Movies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Movies.Core.RentalManager
{
    public interface IRentalManager
    {
        Task<ResultHelper<IEnumerable<Rental>>> GetRentalsAsync();
        Task<ResultHelper<Rental>> GetByIdAsync(int id);
        Task<ResultHelper<Rental>> CreateRentalAsync(Rental rental);

        //Detail Rental
        Task<ResultHelper<IEnumerable<DetailRental>>> GetRentalsDetailAsync();
        Task<ResultHelper<DetailRental>> GetByIdDetailAsync(int id);
        Task<ResultHelper<DetailRental>> CreateRentalDetailAsync(DetailRental detailRental);
    }
}
