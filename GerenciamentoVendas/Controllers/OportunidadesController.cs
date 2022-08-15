using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GerenciamentoVendas.Models;

namespace GerenciamentoVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OportunidadesController : ControllerBase
    {
        private readonly BancoContext _context;

        public OportunidadesController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/Oportunidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oportunidade>>> GetOportunidade()
        {
            return await _context.Oportunidade.ToListAsync();
        }

        // GET: api/Oportunidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oportunidade>> GetOportunidade(int id)
        {
            var oportunidade = await _context.Oportunidade.FindAsync(id);

            if (oportunidade == null)
            {
                return NotFound();
            }

            return oportunidade;
        }

        // PUT: api/Oportunidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOportunidade(int id, Oportunidade oportunidade)
        {
            if (id != oportunidade.Id)
            {
                return BadRequest();
            }

            _context.Entry(oportunidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OportunidadeExists(id))
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

        // POST: api/Oportunidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Oportunidade>> PostOportunidade(Oportunidade oportunidade)
        {

            var informacoesOportunidades = await oportunidade.ObterInformacoes();

            //informacoesOportunidades.cnpj_raiz;
            string regiaoId = informacoesOportunidades.Estabelecimento.Estado.GetRegiaoId();

            //_context.Usuario
            //    .Include("RegiaoResponsavel")
            //    .Where(o => o.RegiaoResponsavel = regiaoId); // Query de filtrar o usuario por regiao e tem que ser igual ao região id

            _context.Oportunidade.Add(oportunidade);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetOportunidade", new { id = oportunidade.CNPJ }, oportunidade);
            return CreatedAtAction(nameof(GetOportunidade), new { id = oportunidade.Id }, oportunidade);
        }

        // DELETE: api/Oportunidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOportunidade(int id)
        {
            var oportunidade = await _context.Oportunidade.FindAsync(id);
            if (oportunidade == null)
            {
                return NotFound();
            }

            _context.Oportunidade.Remove(oportunidade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OportunidadeExists(int id)
        {
            return _context.Oportunidade.Any(e => e.Id == id);
        }
    }
}
