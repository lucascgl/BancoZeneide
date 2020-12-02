using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Pedido
    {
        public Pedido()
        {
        }

        public Pedido(int pedidoId, Vendedor vendedor, Cliente cliente, Pet pet, Categoria categoria, DateTime dataVenda, int quantidadeItensComprada, double valorTotal)
        {
            PedidoId = pedidoId;
            Vendedor = vendedor;
            Cliente = cliente;
            Pet = pet;
            Categoria = categoria;
            DataVenda = dataVenda;
            QuantidadeItensComprada = quantidadeItensComprada;
            ValorTotal = valorTotal;
        }

        [Key]
        public int PedidoId { get; set; }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public Pet Pet { get; set; }
        public ICollection<Produto> Produto { get; set; } = new List<Produto>();
        public Categoria Categoria { get; set; }
        public DateTime DataVenda { get; set; }
        public int QuantidadeItensComprada { get; set; }
        public double ValorTotal { get; set; }
        public double Amount { get; internal set; }


    }
}
