using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prs.Models;

namespace prs_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Request_LinesController : ControllerBase
    {
        private readonly PrsDbContext _context;

        public Request_LinesController(PrsDbContext context)
        {
            _context = context;
        }

        // GET: api/Request_Lines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request_Lines>>> GetRequest_Lines()
        {
            return await _context.Request_Lines.ToListAsync();
        }

        // GET: api/Request_Lines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Request_Lines>> GetRequest_Lines(int id)
        {
            var request_Lines = await _context.Request_Lines.FindAsync(id);

            if (request_Lines == null)
            {
                return NotFound();
            }

            return request_Lines;
        }

        // PUT: api/Request_Lines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest_Lines(int id, Request_Lines request_Lines)
        {
            if (id != request_Lines.Id)
            {
                return BadRequest();
            }

            _context.Entry(request_Lines).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Request_LinesExists(id))
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

        // POST: api/Request_Lines
        [HttpPost]
        public async Task<ActionResult<Request_Lines>> PostRequest_Lines(Request_Lines request_Lines)
        {
            _context.Request_Lines.Add(request_Lines);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequest_Lines", new { id = request_Lines.Id }, request_Lines);
        }

        // DELETE: api/Request_Lines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Request_Lines>> DeleteRequest_Lines(int id)
        {
            var request_Lines = await _context.Request_Lines.FindAsync(id);
            if (request_Lines == null)
            {
                return NotFound();
            }

            _context.Request_Lines.Remove(request_Lines);
            await _context.SaveChangesAsync();

            return request_Lines;
        }

        private bool Request_LinesExists(int id)
        {
            return _context.Request_Lines.Any(e => e.Id == id);
        }
    }
}
