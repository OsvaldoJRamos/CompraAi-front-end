using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Dominio;

namespace CompraAi.Servicos.Interfaces
{
    public interface IUsuario
    {
        Task<string> CadastrarUsuarioAsync(Usuario usuario);
        Task<string> AceitarConviteUsuarioAsync(Convite convite);
        Task<Familia> RetornaFamiliaUsuarioAsync( string usuarioId);
    }
}
