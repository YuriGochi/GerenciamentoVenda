using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models
{
    public class Oportunidade
    {
        [Key]
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public int ValorMonetario { get; set; }

        public async Task<ApiCNPJ> ObterInformacoes()
        {
            var client = new HttpClient { BaseAddress = new Uri("https://publica.cnpj.ws") };
            var response = await client.GetAsync($"cnpj/{CNPJ}");

            var responseAsString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiCNPJ>(responseAsString);

        }
    }
    
}
