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
    public  class ConviteServico:ConviteInterface
    {
        HttpClient client = new HttpClient();
        public async Task<string> CadastrarConviteAsync(Convite convite)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Convite";
                var data = JsonConvert.SerializeObject(convite);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Cadastrar Convite");
                }
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
