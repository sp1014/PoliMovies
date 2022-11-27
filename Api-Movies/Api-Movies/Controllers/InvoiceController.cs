using Api_Movies.Core.InvoiceManager;
using Api_Movies.Core.QualificationManager;
using Api_Movies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api_Movies.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceManager _invoiceManager;
        public InvoiceController(IInvoiceManager invoiceManager)
        {
            _invoiceManager = invoiceManager;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usersResult = await _invoiceManager.GetInvoiceAsync();
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
            var ordenResult = await _invoiceManager.GetByIdAsync(id);
            if (ordenResult.Success)
            {
                return Ok(ordenResult.Value);
            }
            return NotFound(ordenResult.Errors);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Invoice invoice)
        {
            var result = await _invoiceManager.CreateInvoiceAsync(invoice);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
            }
            return BadRequest(result.Errors);
        }
    }
}
