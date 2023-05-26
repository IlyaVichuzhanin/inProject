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
    public class StructuredLogsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StructuredLogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/StructuredLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StructuredLog>>> GetStructuredLogs()
        {
          if (_context.StructuredLogs == null)
          {
              return NotFound();
          }
            return await _context.StructuredLogs.ToListAsync();
        }

        // GET: api/StructuredLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StructuredLog>> GetStructuredLog(int? id)
        {
          if (_context.StructuredLogs == null)
          {
              return NotFound();
          }
            var structuredLog = await _context.StructuredLogs.FindAsync(id);

            if (structuredLog == null)
            {
                return NotFound();
            }

            return structuredLog;
        }

        // PUT: api/StructuredLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStructuredLog(int? id, StructuredLog structuredLog)
        {
            if (id != structuredLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(structuredLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StructuredLogExists(id))
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

        // POST: api/StructuredLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StructuredLog>> PostStructuredLog(StructuredLog structuredLog)
        {
          if (_context.StructuredLogs == null)
          {
              return Problem("Entity set 'AppDbContext.StructuredLogs'  is null.");
          }
            _context.StructuredLogs.Add(structuredLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStructuredLog", new { id = structuredLog.Id }, structuredLog);
        }

        // DELETE: api/StructuredLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStructuredLog(int? id)
        {
            if (_context.StructuredLogs == null)
            {
                return NotFound();
            }
            var structuredLog = await _context.StructuredLogs.FindAsync(id);
            if (structuredLog == null)
            {
                return NotFound();
            }

            _context.StructuredLogs.Remove(structuredLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StructuredLogExists(int? id)
        {
            return (_context.StructuredLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
