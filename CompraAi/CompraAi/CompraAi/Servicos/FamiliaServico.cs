using CompraAi.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Dominio;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CompraAi.Servicos
{
    public class FamiliaServico:IFamilia
    {
        HttpClient client = new HttpClient();
        public async Task<string> CadastrarFamiliaAsync(Familia familia)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Familia";
                var data = JsonConvert.SerializeObject(familia);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Cadastrar Familia");
                }
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task<List<Usuario>> ReceberMembroFamiliaAsync(string familiaId)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Familia/{0}/ObterMembros";
                var uri = new Uri(string.Format(url, familiaId));
                var response = await client.GetStringAsync(url);
                var item = JsonConvert.DeserializeObject<List<Usuario>>(response);
                return item;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
