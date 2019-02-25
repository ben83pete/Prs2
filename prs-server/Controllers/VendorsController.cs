using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prs.Models;

namespace prs_server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase {
        private readonly PrsDbContext _context;

        public VendorsController(PrsDbContext context) {
            _context = context;
        }

        // GET: api/Vendors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendor>>> GetVendors() {
            return await _context.Vendor.ToListAsync();
        }

        // GET: api/Vendors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetVendors(int id) {
            var vendors = await _context.Vendor.FindAsync(id);

            if (vendors == null) {
                return NotFound();
            }

            return vendors;
        }

        // PUT: api/Vendors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendors(int id, Vendor vendors) {
            if (id != vendors.Id) {
                return BadRequest();
            }

            _context.Entry(vendors).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!VendorsExists(id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vendors
        [HttpPost]
        public async Task<ActionResult<Vendor>> PostVendors(Vendor vendors) {
            _context.Vendor.Add(vendors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendors", new { id = vendors.Id }, vendors);
        }

        // DELETE: api/Vendors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vendor>> DeleteVendors(int id) {
            var vendors = await _context.Vendor.FindAsync(id);
            if (vendors == null) {
                return NotFound();
            }

            _context.Vendor.Remove(vendors);
            await _context.SaveChangesAsync();

            return vendors;
        }

        private bool VendorsExists(int id) {
            return _context.Vendor.Any(e => e.Id == id);
        }
    }
}
