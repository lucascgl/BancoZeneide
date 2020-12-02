using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(int id, string nomeProduto, double valorProduto, string descricao, Categoria categoria)
        {
            ProdutoId = id;
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            Descricao = descricao;
            Categoria = categoria;
        }

        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }

        [Key]
        public int ProdutoId { get; set; }
    }
}
