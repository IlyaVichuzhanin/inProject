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
    public class tNavPrimaryLogsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public tNavPrimaryLogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/tNavPrimaryLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tNavPrimaryLog>>> GettNavPrimaryLogs()
        {
          if (_context.tNavPrimaryLogs == null)
          {
              return NotFound();
          }
            return await _context.tNavPrimaryLogs.ToListAsync();
        }

        // GET: api/tNavPrimaryLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tNavPrimaryLog>> GettNavPrimaryLog(long? id)
        {
          if (_context.tNavPrimaryLogs == null)
          {
              return NotFound();
          }
            var tNavPrimaryLog = await _context.tNavPrimaryLogs.FindAsync(id);

            if (tNavPrimaryLog == null)
            {
                return NotFound();
            }

            return tNavPrimaryLog;
        }

        // PUT: api/tNavPrimaryLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PuttNavPrimaryLog(long? id, tNavPrimaryLog tNavPrimaryLog)
        {
            if (id != tNavPrimaryLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(tNavPrimaryLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tNavPrimaryLogExists(id))
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

        // POST: api/tNavPrimaryLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<tNavPrimaryLog>> PosttNavPrimaryLog(tNavPrimaryLog tNavPrimaryLog)
        {
          if (_context.tNavPrimaryLogs == null)
          {
              return Problem("Entity set 'AppDbContext.tNavPrimaryLogs'  is null.");
          }
            _context.tNavPrimaryLogs.Add(tNavPrimaryLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GettNavPrimaryLog", new { id = tNavPrimaryLog.Id }, tNavPrimaryLog);
        }

        // DELETE: api/tNavPrimaryLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletetNavPrimaryLog(long? id)
        {
            if (_context.tNavPrimaryLogs == null)
            {
                return NotFound();
            }
            var tNavPrimaryLog = await _context.tNavPrimaryLogs.FindAsync(id);
            if (tNavPrimaryLog == null)
            {
                return NotFound();
            }

            _context.tNavPrimaryLogs.Remove(tNavPrimaryLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool tNavPrimaryLogExists(long? id)
        {
            return (_context.tNavPrimaryLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
