using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace GerenciamentoVendas.Models
{
    public class Estado
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("ibge_id")]
        public int IbgeId { get; set; }

        public int GetRegiaoId()
        {
            var query = IbgeId.ToString()[0];//retornar o id da região em int pegando o ibge id e o primeiro caractere pq define a regiao
            return query;
        }
    }
}