using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NETCoreVoya.Context;
using ASP.NETCoreVoya.Models;

namespace ASP.NETCoreVoya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PromocoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Promocoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promocao>>> GetPromocao()
        {
            return await _context.Promocao.ToListAsync();
        }

        // GET: api/Promocoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Promocao>> GetPromocao(long id)
        {
            var promocao = await _context.Promocao.FindAsync(id);

            if (promocao == null)
            {
                return NotFound();
            }

            return promocao;
        }

        // PUT: api/Promocoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromocao(long id, Promocao promocao)
        {
            if (id != promocao.Id)
            {
                return BadRequest();
            }

            _context.Entry(promocao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromocaoExists(id))
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

        // POST: api/Promocoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Promocao>> PostPromocao(Promocao promocao)
        {
            _context.Promocao.Add(promocao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPromocao", new { id = promocao.Id }, promocao);
        }

        // DELETE: api/Promocoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromocao(long id)
        {
            var promocao = await _context.Promocao.FindAsync(id);
            if (promocao == null)
            {
                return NotFound();
            }

            _context.Promocao.Remove(promocao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PromocaoExists(long id)
        {
            return _context.Promocao.Any(e => e.Id == id);
        }
    }
}
