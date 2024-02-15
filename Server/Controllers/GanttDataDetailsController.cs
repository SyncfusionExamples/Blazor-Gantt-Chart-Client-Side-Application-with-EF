using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GanttWithEF.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GanttWithEF.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GanttDataDetailsController : ControllerBase
    {
        private readonly EfWasmContext _context;

        public GanttDataDetailsController(EfWasmContext context)
        {
            _context = context;
        }

        // GET: api/GanttDataDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDatum>>> GetGanttData()
        {
            return await _context.TaskData.ToListAsync();
        }

        // GET: api/GanttDataDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDatum>> GetGanttDataDetails(int id)
        {
            var ganttDataDetails = await _context.TaskData.FindAsync(id);

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
        public async Task<IActionResult> PutGanttDataDetails(int id, TaskDatum ganttDataDetails)
        {
            if (id != ganttDataDetails.TaskId)
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
        public async Task<ActionResult<TaskDatum>> PostGanttDataDetails(TaskDatum ganttDataDetails)
        {
            _context.TaskData.Add(ganttDataDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGanttDataDetails", new { id = ganttDataDetails.TaskId }, ganttDataDetails);
        }

        // DELETE: api/GanttDataDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskDatum>> DeleteGanttDataDetails(int id)
        {
            var ganttDataDetails = await _context.TaskData.FindAsync(id);
            if (ganttDataDetails == null)
            {
                return NotFound();
            }

            _context.TaskData.Remove(ganttDataDetails);
            await _context.SaveChangesAsync();

            return ganttDataDetails;
        }

        private bool GanttDataDetailsExists(int id)
        {
            return _context.TaskData.Any(e => e.TaskId == id);
        }
    }
}
