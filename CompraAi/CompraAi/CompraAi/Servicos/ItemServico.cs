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
    public class ItemServico : IItemServico
    {
        HttpClient client = new HttpClient();
        public async Task CadastrarItemAsync(Item item)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Item";
                var data = JsonConvert.SerializeObject(item);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao incluir Item");
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task AtualizarItemAsync(Item item)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/Atualizar";
                var data = JsonConvert.SerializeObject(item);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Atualizar Item");
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task ExcluirItemAsync(string itemId)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Item/{0}";
                var uri = new Uri(string.Format(url, itemId));
                HttpResponseMessage response = null;
                response = await client.DeleteAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Excluir Item");
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task<Item> ReceberItemAsync(string itemId)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Item/{0}";
                var uri = new Uri(string.Format(url, itemId));
                var response = await client.GetStringAsync(url);
                var item = JsonConvert.DeserializeObject<Item>(response);
                return item;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task CadastrarImagemAsync(string itemId, byte[] imagemProduto)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Item/Imagem/{0}";
                var uri = new Uri(string.Format(url, itemId));
                var requestContent = new MultipartFormDataContent();
                var imageContent = new ByteArrayContent(imagemProduto);
                imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                requestContent.Add(imageContent, "image", "image.jpg");
                var response = await client.PostAsync(uri, requestContent);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao Cadastrar Imagem");
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task<string> ReceberImagemAsync(string itemId)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Item/Imagem/{0}";
                var uri = new Uri(string.Format(url, itemId));
                var response = await client.GetStringAsync(url);
                var item = JsonConvert.DeserializeObject<string>(response);
                return item;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public async Task<List<Item>> ReceberFamiliaAsync(string itemId)
        {
            try
            {
                string url = "http://compraai-back-end.azurewebsites.net/api/Item/Familia/{0}";
                var uri = new Uri(string.Format(url, itemId));
                var response = await client.GetStringAsync(url);
                var item = JsonConvert.DeserializeObject<List<Item>>(response);
                return item;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
