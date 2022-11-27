using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api_Movies.Core.UserManager;
using Api_Movies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Api_Movies.Core.RentalManager;

namespace Api_Movies.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalManager _rentalManager;
        public RentalController(IRentalManager rentalManager)
        {
            _rentalManager = rentalManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usersResult = await _rentalManager.GetRentalsAsync();
            if (usersResult.Success)
            {
                return Ok(usersResult.Value);
            }
            return NotFound(usersResult.Errors);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var ordenResult = await _rentalManager.GetByIdAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Rental rental)
        {
            var result = await _rentalManager.CreateRentalAsync(rental);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
            }
            return BadRequest(result.Errors);
        }

         //DetailRental
        
        [AllowAnonymous]
        [HttpGet("DetailRental")]
        public async Task<ActionResult> GetAllDetail()
        {
            var usersResult = await _rentalManager.GetRentalsDetailAsync();
            if (usersResult.Success)
            {
                return Ok(usersResult.Value);
            }
            return NotFound(usersResult.Errors);
        }
        [AllowAnonymous]
        [HttpGet("DetailRental/{id}")]
        public async Task<ActionResult> GetByIdDetail(int id)
        {
            var ordenResult = await _rentalManager.GetByIdDetailAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
        }


        [HttpPost("DetailRental")]
        public async Task<ActionResult> Post(DetailRental detailRental)
        {
            var result = await _rentalManager.CreateRentalDetailAsync(detailRental);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
            }
            return BadRequest(result.Errors);
        }


    }
}
