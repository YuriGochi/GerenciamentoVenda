using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public enum Regiao
    {
        Norte,
        Nordeste,
        Sudeste,
        Sul,
        CentroOeste
    }
    public class Usuario
    { 
        public string Id { get; set; }
        public string Nome { get; set; }
        [Key]
        public string Email { get; set; }
        public Regiao RegiaoResponsavel { get; set; }
    }
}
