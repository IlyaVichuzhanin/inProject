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
    public class PetexPrimaryLogsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PetexPrimaryLogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PetexPrimaryLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PetexPrimaryLog>>> GetPetexPrimaryLogs()
        {
          if (_context.PetexPrimaryLogs == null)
          {
              return NotFound();
          }
            return await _context.PetexPrimaryLogs.ToListAsync();
        }

        // GET: api/PetexPrimaryLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PetexPrimaryLog>> GetPetexPrimaryLog(long id)
        {
          if (_context.PetexPrimaryLogs == null)
          {
              return NotFound();
          }
            var petexPrimaryLog = await _context.PetexPrimaryLogs.FindAsync(id);

            if (petexPrimaryLog == null)
            {
                return NotFound();
            }

            return petexPrimaryLog;
        }

        // PUT: api/PetexPrimaryLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPetexPrimaryLog(long id, PetexPrimaryLog petexPrimaryLog)
        {
            if (id != petexPrimaryLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(petexPrimaryLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetexPrimaryLogExists(id))
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

        // POST: api/PetexPrimaryLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PetexPrimaryLog>> PostPetexPrimaryLog(PetexPrimaryLog petexPrimaryLog)
        {
          if (_context.PetexPrimaryLogs == null)
          {
              return Problem("Entity set 'AppDbContext.PetexPrimaryLogs'  is null.");
          }
            _context.PetexPrimaryLogs.Add(petexPrimaryLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPetexPrimaryLog", new { id = petexPrimaryLog.Id }, petexPrimaryLog);
        }

        // DELETE: api/PetexPrimaryLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePetexPrimaryLog(long id)
        {
            if (_context.PetexPrimaryLogs == null)
            {
                return NotFound();
            }
            var petexPrimaryLog = await _context.PetexPrimaryLogs.FindAsync(id);
            if (petexPrimaryLog == null)
            {
                return NotFound();
            }

            _context.PetexPrimaryLogs.Remove(petexPrimaryLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PetexPrimaryLogExists(long id)
        {
            return (_context.PetexPrimaryLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
