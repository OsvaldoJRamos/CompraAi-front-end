﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompraAi.Dominio
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public Guid FamiliaId { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid StatusId { get; set; }
        public string Descricao { get; set; }
        public byte[] ImagemProduto { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AlteradoEm { get; set; }
    }
}
