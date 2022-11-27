using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api_Movies.Core.UserManager;
using Api_Movies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Api_Movies.Core.RentalManager;
using Api_Movies.Core.SaleManager;
using Api_Movies.Helpers;
using System;

namespace Api_Movies.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleManager _saleManager;
        public SaleController(ISaleManager saleManager)
        {
            _saleManager = saleManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usersResult = await _saleManager.GetSalesAsync();
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
            var ordenResult = await _saleManager.GetByIdAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Sale sale)
        {
            var result = await _saleManager.CreateSalesAsync(sale);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
            }
            return BadRequest(result.Errors);
        }

        [AllowAnonymous]
        [HttpGet("SaleDetail")]
        public async Task<ActionResult> GetAllDestail()
        {
            var usersResult = await _saleManager.GetSalesDetailAsync();
            if (usersResult.Success)
            {
                return Ok(usersResult.Value);
            }
            return NotFound(usersResult.Errors);
        }
        [AllowAnonymous]
        [HttpGet("SaleDetail/{id}")]
        public async Task<ActionResult> GetByIdDetail(int id)
        {
            var ordenResult = await _saleManager.GetByIdDetailAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
        }


        [HttpPost("SaleDetail")]
        public async Task<ActionResult> Post(DetailSale detailSale)
        {
            var result = await _saleManager.CreateSalesDetailAsync(detailSale);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
            }
            return BadRequest(result.Errors);
        }

    }
}
