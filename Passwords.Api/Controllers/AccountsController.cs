using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Passwords.Api.Data.Context;
using System.Linq;
using Passwords.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Passwords.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly PasswordContext _context;

        public AccountsController(PasswordContext context)
        {
            _context = context;
        }

        // GET api/account
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            using(var conn = _context)
            {
                var accounts = conn.Account.Include(c => c.Contents).ToList();

                return new ObjectResult(accounts);
            }
        }

        // GET api/account/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            using (var conn = _context)
            {
                return Ok(conn.Account.Find(id));
            }
        }

        // POST api/account
        [HttpPost]
        public ActionResult Post([FromBody] Account account)
        {
            using (var conn = _context)
            {
                conn.Account.Add(account);
                conn.SaveChanges();
            }

            return Ok(account);
        }

        // PUT api/account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
