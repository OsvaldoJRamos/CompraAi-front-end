using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Dominio;

namespace CompraAi.Servicos.Interfaces
{
    public interface IItemServico
    {
        Task  CadastrarItemAsync(Item item);
        Task AtualizarItemAsync( Item item);
        Task ExcluirItemAsync(string itemId);
        Task<Item> ReceberItemAsync(string itemId);
        Task CadastrarImagemAsync(string itemId, byte[] imagemProduto);
        Task<string> ReceberImagemAsync(string itemId);
        Task <List<Item>> ReceberFamiliaAsync (string itemId);


    }
}
