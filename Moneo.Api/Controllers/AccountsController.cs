using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Moneo.Api.Data;
using Moneo.Api.Dtos;
using Moneo.Api.Models;

namespace Moneo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly MoneoDbContext _context;

        public AccountsController(MoneoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountDto>>> GetAccounts()
        {

            var accounts = await _context.Accounts
                .Select(a => new AccountDto(
                    a.Id,
                    a.Name,
                    a.Type,
                    a.InitialBalance,
                    a.CreatedAt,
                    a.InitialBalance + a.Operations.Sum(o => o.Amount)))
                .ToListAsync();

            return Ok(accounts);
        }

    }
}
