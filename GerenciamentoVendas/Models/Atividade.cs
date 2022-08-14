using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public class Atividade
    {
        [Key]
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
    }
}
