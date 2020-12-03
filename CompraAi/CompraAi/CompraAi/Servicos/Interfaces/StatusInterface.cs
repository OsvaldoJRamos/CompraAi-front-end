using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Dominio;

namespace CompraAi.Servicos.Interfaces
{
    public interface StatusInterface
    {
        Task<Status> ReceberStatusAsync();

    }
}
