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
    public class QAsController : ControllerBase
    {
        private readonly Context _context;

        public QAsController(Context context)
        {
            _context = context;
        }

        // GET: api/QAs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QA>>> GetQandA()
        {
            return await _context.QandA.ToListAsync();
        }

        // GET: api/QAs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QA>> GetQA(int id)
        {
            var qA = await _context.QandA.FindAsync(id);

            if (qA == null)
            {
                return NotFound();
            }

            return qA;
        }

        // PUT: api/QAs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQA(int id, QA qA)
        {
            if (id != qA.ID)
            {
                return BadRequest();
            }

            _context.Entry(qA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QAExists(id))
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

        // POST: api/QAs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<QA>> PostQA(QA qA)
        {
            _context.QandA.Add(qA);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQA", new { id = qA.ID }, qA);
        }

        // DELETE: api/QAs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QA>> DeleteQA(int id)
        {
            var qA = await _context.QandA.FindAsync(id);
            if (qA == null)
            {
                return NotFound();
            }

            _context.QandA.Remove(qA);
            await _context.SaveChangesAsync();

            return qA;
        }

        private bool QAExists(int id)
        {
            return _context.QandA.Any(e => e.ID == id);
        }
    }
}
