using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_953504_IZGACHEV.Data;
using WEB_953504_IZGACHEV.Entities;

namespace WEB_953504_IZGACHEV.Blazor.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Software>>> GetProducts(int? group)
        {
            var products = _context.Products.Where(d => !group.HasValue || d.SoftwareCategoryId == group.Value);
            return await products.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Software>> GetSoftware(int id)
        {
            var software = await _context.Products.FindAsync(id);

            if (software == null)
            {
                return NotFound();
            }

            return software;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftware(int id, Software software)
        {
            if (id != software.SoftwareId)
            {
                return BadRequest();
            }

            _context.Entry(software).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoftwareExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Software>> PostSoftware(Software software)
        {
            _context.Products.Add(software);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoftware", new { id = software.SoftwareId }, software);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoftware(int id)
        {
            var software = await _context.Products.FindAsync(id);
            if (software == null)
            {
                return NotFound();
            }

            _context.Products.Remove(software);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SoftwareExists(int id)
        {
            return _context.Products.Any(e => e.SoftwareId == id);
        }
    }
}
