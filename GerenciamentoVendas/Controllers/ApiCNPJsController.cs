using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GerenciamentoVendas.Models;
using System.Net;

namespace GerenciamentoVendas.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ApiCNPJsController : ControllerBase
    {

        private readonly BancoContext _context;

        public ApiCNPJsController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/ApiCNPJs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiCNPJ>>> GetApiCNPJ()
        {
            return await _context.ApiCNPJ.ToListAsync();
        }

        // GET: api/ApiCNPJs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiCNPJ>> GetApiCNPJ(int id)
        {
            var apiCNPJ = await _context.ApiCNPJ.FindAsync(id);

            if (apiCNPJ == null)
            {
                return NotFound();
            }

            return apiCNPJ;
        }

        // PUT: api/ApiCNPJs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApiCNPJ(int id, ApiCNPJ apiCNPJ)
        {
            if (id != apiCNPJ.Id)
            {
                return BadRequest();
            }

            _context.Entry(apiCNPJ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApiCNPJExists(id))
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

        // POST: api/ApiCNPJs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApiCNPJ>> PostApiCNPJ(ApiCNPJ apiCNPJ)
        {
            _context.ApiCNPJ.Add(apiCNPJ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApiCNPJ", new { id = apiCNPJ.Id }, apiCNPJ);
        }

        // DELETE: api/ApiCNPJs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApiCNPJ(int id)
        {
            var apiCNPJ = await _context.ApiCNPJ.FindAsync(id);
            if (apiCNPJ == null)
            {
                return NotFound();
            }

            _context.ApiCNPJ.Remove(apiCNPJ);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApiCNPJExists(int id)
        {
            return _context.ApiCNPJ.Any(e => e.Id == id);
        }
    }
}
