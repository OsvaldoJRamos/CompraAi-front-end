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
    public class UsuarioServico:IUsuario
    {
        HttpClient client = new HttpClient();
        public async Task<string> CadastrarUsuarioAsync(Usuario usuario)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Usuario";
                var data = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Cadastrar Usuario");
                }
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public async Task<string> AceitarConviteUsuarioAsync(Convite convite)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Usuario/AceitarConvite";
                var data = JsonConvert.SerializeObject(convite);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Aceitar Convite do Usuario");
                }
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public async Task<Familia> RetornaFamiliaUsuarioAsync(string usuarioId)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Usuario/{0}/ObterFamilia";
                var uri = new Uri(string.Format(url,usuarioId));
                var response = await client.GetStringAsync(url);
                var item = JsonConvert.DeserializeObject<Familia>(response);
                return item;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
