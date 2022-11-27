using Api_Movies.Core.RentalManager;
using Api_Movies.Core.SerieManager;
using Api_Movies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api_Movies.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private readonly ISerieManager _serieManager;
        public SerieController(ISerieManager serieManager)
        {
            _serieManager = serieManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usersResult = await _serieManager.GetSeriesAsync();
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
            var ordenResult = await _serieManager.GetByIdAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Serie serie)
        {
            var result = await _serieManager.CreateSeriesAsync(serie);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
            }
            return BadRequest(result.Errors);
        }
    }
}
