using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public class Estabelecimento
    {
        [Key]
        public string Id { get; set; }
        public string cnpj { get; set; }
        public Estado Estado { get; set; }
        [JsonProperty("atividade_principal")]
        public Atividade AtividadePrincipal { get; set; }

    }
}
