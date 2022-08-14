using Newtonsoft.Json;
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
        [JsonProperty("cnpj_raiz")]
        public string CnpjRaiz { get; set; }
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
    }
}
