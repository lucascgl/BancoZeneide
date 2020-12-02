using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Categoria
    {
        public Categoria(int idCategoria, string nomeCategoria, string nivelCategoria)
        {
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
            NivelCategoria = nivelCategoria;
        }

        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string NivelCategoria { get; set; }

    }
}
