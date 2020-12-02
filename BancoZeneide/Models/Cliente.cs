using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Cliente
    {

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string telefone, string email, string cep, string endereco, int numero, string cidade, string estado, string cpf, string cnpj)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Cpf = cpf;
            Cnpj = cnpj;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        [Key]
        public int Id { get; set; }


    }
}
