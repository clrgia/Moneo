using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Moneo.Api.Data;
using Moneo.Api.Dtos;
using Moneo.Api.Models;

namespace Moneo.Api.Controllers
{
    [Route("api/accounts/{accountId}/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        private readonly MoneoDbContext _context;

        public OperationsController(MoneoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperationDto>>> GetOperations(Guid accountId)
        {
            if (await _context.Accounts.AnyAsync(x => x.Id == accountId) == false)
            {
                return NotFound();
            }

            var operations = await _context.Operations
                .Where(x => x.AccountId == accountId)
                .OrderByDescending(o => o.Date)
                .Select(o => new OperationDto(
                    o.Id,
                    o.Label,
                    o.Amount,
                    o.Date,
                    o.AccountId,
                    o.CategoryId,
                    o.Category != null ? o.Category.Label : null))
                .ToListAsync();

            return Ok(operations);
        }

    }
}
