using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Pedido : Cliente
    {
        public Pedido()
        {
        }

        public Pedido(int quantidadeItensComprada, int numeroPedido, DateTime data, double valorTotal, int id, string nome)
        {
            Id = id;
            Nome = nome;
            QuantidadeItensComprada = quantidadeItensComprada;
            NumeroPedido = numeroPedido;
            Data = data;
            ValorTotal = valorTotal;
        }

        public int QuantidadeItensComprada { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
    }
}
