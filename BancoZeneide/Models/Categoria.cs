using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Categoria
    {
        public Categoria()
        {
        }

        public Categoria(int idCategoria, string nomeCategoria, string nivelCategoria)
        {
            
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
            NivelCategoria = nivelCategoria;
        }

        public string NomeCategoria { get; set; }
        public string NivelCategoria { get; set; }
        [Key]
        public int IdCategoria { get; set; }



    }
}
