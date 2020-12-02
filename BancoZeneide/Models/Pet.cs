using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Pet
    {
        [Key]
        public int IdPet { get; set; }
        public Pet()
        {
        }


        public Pet(int idPet, char sexo, string raca, string peso, Cliente cliente)
        {
            Cliente = cliente;
            IdPet = idPet;
            Sexo = sexo;
            Raca = raca;
            Peso = peso;
        }


        public char Sexo { get; set; }
        public string Raca { get; set; }
        public string Peso { get; set; }
        public Cliente Cliente { get; set; }


    }
}
