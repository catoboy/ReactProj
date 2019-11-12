using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VYFAQ.Model;

namespace VYFAQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class innQAsController : ControllerBase
    {
        private readonly Context _context;

        public innQAsController(Context context)
        {
            _context = context;
        }

        // GET: api/innQAs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<innQA>>> GetinnQA()
        {
            return await _context.innQA.ToListAsync();
        }

        // GET: api/innQAs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<innQA>> GetinnQA(int id)
        {
            var innQA = await _context.innQA.FindAsync(id);

            if (innQA == null)
            {
                return NotFound();
            }

            return innQA;
        }

        // PUT: api/innQAs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutinnQA(int id, innQA innQA)
        {
            if (id != innQA.ID)
            {
                return BadRequest();
            }

            _context.Entry(innQA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!innQAExists(id))
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

        // POST: api/innQAs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<innQA>> PostinnQA(innQA innQA)
        {
            _context.innQA.Add(innQA);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetinnQA", new { id = innQA.ID }, innQA);
        }

        // DELETE: api/innQAs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<innQA>> DeleteinnQA(int id)
        {
            var innQA = await _context.innQA.FindAsync(id);
            if (innQA == null)
            {
                return NotFound();
            }

            _context.innQA.Remove(innQA);
            await _context.SaveChangesAsync();

            return innQA;
        }

        private bool innQAExists(int id)
        {
            return _context.innQA.Any(e => e.ID == id);
        }
    }
}
