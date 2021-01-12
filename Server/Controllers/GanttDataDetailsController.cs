using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Data;
using MyBlazorApp.Shared.DataAccess;

namespace MyBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GanttDataDetailsController : ControllerBase
    {
        private readonly GanttDataContext _context;

        public GanttDataDetailsController(GanttDataContext context)
        {
            _context = context;
        }

        // GET: api/GanttDataDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GanttDataDetails>>> GetGanttData()
        {
            return await _context.GanttData.ToListAsync();
        }

        // GET: api/GanttDataDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GanttDataDetails>> GetGanttDataDetails(int id)
        {
            var ganttDataDetails = await _context.GanttData.FindAsync(id);

            if (ganttDataDetails == null)
            {
                return NotFound();
            }

            return ganttDataDetails;
        }

        // PUT: api/GanttDataDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGanttDataDetails(int id, GanttDataDetails ganttDataDetails)
        {
            if (id != ganttDataDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(ganttDataDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GanttDataDetailsExists(id))
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

        // POST: api/GanttDataDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GanttDataDetails>> PostGanttDataDetails(GanttDataDetails ganttDataDetails)
        {
            _context.GanttData.Add(ganttDataDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGanttDataDetails", new { id = ganttDataDetails.Id }, ganttDataDetails);
        }

        // DELETE: api/GanttDataDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GanttDataDetails>> DeleteGanttDataDetails(int id)
        {
            var ganttDataDetails = await _context.GanttData.FindAsync(id);
            if (ganttDataDetails == null)
            {
                return NotFound();
            }

            _context.GanttData.Remove(ganttDataDetails);
            await _context.SaveChangesAsync();

            return ganttDataDetails;
        }

        private bool GanttDataDetailsExists(int id)
        {
            return _context.GanttData.Any(e => e.Id == id);
        }
    }
}
