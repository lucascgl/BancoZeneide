using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Vendedor
    {
        public Vendedor()
        {
        }

        public Vendedor(int idVendedor, string nomeVendedor, string cpfVendedor, DateTime dataInicio)
        {
            IdVendedor = idVendedor;
            NomeVendedor = nomeVendedor;
            CpfVendedor = cpfVendedor;
            DataInicio = dataInicio;
        }

        public void AdicionarVendas(Pedido sr)
        {
            Pedido.Add(sr);
        }

        public void RemoverVendas(Pedido sr)
        {
            Pedido.Remove(sr);
        }

        public double TotalDeVendas (DateTime inicio, DateTime final)
        {
            return Pedido.Where(sr => sr.DataVenda >= inicio && sr.DataVenda <= final).Sum(sr => sr.Amount);
        }

        public ICollection<Pedido> Pedido { get; set; } = new List<Pedido>();
        public string NomeVendedor { get; set; }
        public string CpfVendedor { get; set; }
        public DateTime DataInicio { get; set; }

        [Key]
        public int IdVendedor { get; set; }
    }
}
