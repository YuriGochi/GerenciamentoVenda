using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public class ApiCNPJ
    {
        [Key]
        public int Id { get; set; }
        public Estado Estado { get; set; }
        public string RazaoSocial { get; set; }
        public string DescricaoAtividadePrincipal { get; set; }
    }
}
