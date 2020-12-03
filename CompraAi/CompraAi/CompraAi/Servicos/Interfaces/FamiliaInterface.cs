using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Dominio;

namespace CompraAi.Servicos.Interfaces
{
    public interface IFamilia
    {
        Task<string> CadastrarFamiliaAsync(Familia familia);
        Task<List<Usuario>> ReceberMembroFamiliaAsync(string familiaId);
        
    }
}
