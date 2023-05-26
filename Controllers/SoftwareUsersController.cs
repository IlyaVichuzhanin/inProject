using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using inProject;
using inProject.Models;

namespace inProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftwareUsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SoftwareUsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SoftwareUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SoftwareUser>>> GetSoftwareUsers()
        {
          if (_context.SoftwareUsers == null)
          {
              return NotFound();
          }
            return await _context.SoftwareUsers.ToListAsync();
        }

        // GET: api/SoftwareUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SoftwareUser>> GetSoftwareUser(int? id)
        {
          if (_context.SoftwareUsers == null)
          {
              return NotFound();
          }
            var softwareUser = await _context.SoftwareUsers.FindAsync(id);

            if (softwareUser == null)
            {
                return NotFound();
            }

            return softwareUser;
        }

        // PUT: api/SoftwareUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftwareUser(int? id, SoftwareUser softwareUser)
        {
            if (id != softwareUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(softwareUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoftwareUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SoftwareUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SoftwareUser>> PostSoftwareUser(SoftwareUser softwareUser)
        {
          if (_context.SoftwareUsers == null)
          {
              return Problem("Entity set 'AppDbContext.SoftwareUsers'  is null.");
          }
            _context.SoftwareUsers.Add(softwareUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoftwareUser", new { id = softwareUser.Id }, softwareUser);
        }

        // DELETE: api/SoftwareUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoftwareUser(int? id)
        {
            if (_context.SoftwareUsers == null)
            {
                return NotFound();
            }
            var softwareUser = await _context.SoftwareUsers.FindAsync(id);
            if (softwareUser == null)
            {
                return NotFound();
            }

            _context.SoftwareUsers.Remove(softwareUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SoftwareUserExists(int? id)
        {
            return (_context.SoftwareUsers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
