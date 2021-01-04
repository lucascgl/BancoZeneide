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

        [Display(Name = "Nome do Vendedor")]
        public string NomeVendedor { get; set; }

        [Display(Name = "CPF do Vendedor")]
        public string CpfVendedor { get; set; }

        [Display(Name = "Data de cadastro")]
        public DateTime DataInicio { get; set; }


        [Display(Name = "Data de aniversário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Aniversário { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Senha { get; set; }

        [Key]
        public int IdVendedor { get; set; }
    }
}
