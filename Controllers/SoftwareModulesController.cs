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
    public class SoftwareModulesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SoftwareModulesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SoftwareModules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SoftwareModule>>> GetSoftwareModules()
        {
          if (_context.SoftwareModules == null)
          {
              return NotFound();
          }
            return await _context.SoftwareModules.ToListAsync();
        }

        // GET: api/SoftwareModules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SoftwareModule>> GetSoftwareModule(int id)
        {
          if (_context.SoftwareModules == null)
          {
              return NotFound();
          }
            var softwareModule = await _context.SoftwareModules.FindAsync(id);

            if (softwareModule == null)
            {
                return NotFound();
            }

            return softwareModule;
        }

        // PUT: api/SoftwareModules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftwareModule(int id, SoftwareModule softwareModule)
        {
            if (id != softwareModule.Id)
            {
                return BadRequest();
            }

            _context.Entry(softwareModule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoftwareModuleExists(id))
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

        // POST: api/SoftwareModules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SoftwareModule>> PostSoftwareModule(SoftwareModule softwareModule)
        {
          if (_context.SoftwareModules == null)
          {
              return Problem("Entity set 'AppDbContext.SoftwareModules'  is null.");
          }
            _context.SoftwareModules.Add(softwareModule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoftwareModule", new { id = softwareModule.Id }, softwareModule);
        }

        // DELETE: api/SoftwareModules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoftwareModule(int id)
        {
            if (_context.SoftwareModules == null)
            {
                return NotFound();
            }
            var softwareModule = await _context.SoftwareModules.FindAsync(id);
            if (softwareModule == null)
            {
                return NotFound();
            }

            _context.SoftwareModules.Remove(softwareModule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SoftwareModuleExists(int id)
        {
            return (_context.SoftwareModules?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
