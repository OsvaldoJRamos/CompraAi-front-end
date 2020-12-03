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
    public class StatusServico:StatusInterface
    {
        HttpClient client = new HttpClient();
        public async Task<Status> ReceberStatusAsync()
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Status";               
                var response = await client.GetStringAsync(url);
                var status = JsonConvert.DeserializeObject<Status>(response);
                return status;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
