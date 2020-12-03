using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Dominio;

namespace CompraAi.Servicos.Interfaces
{
    public interface ConviteInterface
    {
        Task<string> CadastrarConviteAsync(Convite convite);
    }
}
