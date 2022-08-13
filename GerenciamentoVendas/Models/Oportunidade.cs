using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public class Oportunidade
    {
        [Key]
        public long CNPJ { get; set; }
        public string Nome { get; set; }
        public int ValorMonetario { get; set; }
    }
}
