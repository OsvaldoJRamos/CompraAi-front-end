using System;
using System.Collections.Generic;
using System.Text;

namespace CompraAi.Dominio
{
    public class Familia
    {
        public Guid FamiliaId { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AlteradoEm { get; set; }
    }
}
