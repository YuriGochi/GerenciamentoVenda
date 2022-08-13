using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoVendas.Models;

namespace GerenciamentoVendas.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {

        }
        public DbSet<GerenciamentoVendas.Models.Usuario> Usuario { get; set; }
        public DbSet<GerenciamentoVendas.Models.Oportunidade> Oportunidade { get; set; }
        public DbSet<GerenciamentoVendas.Models.ApiCNPJ> ApiCNPJ { get; set; }
    }
}
