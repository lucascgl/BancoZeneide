using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Models
{
    public class Pet : Cliente
    {
        public Pet()
        {
        }


        public Pet(int idPet, char sexo, string raca, string peso, int id, string nome)
        {
            Id = id;
            Nome = nome;
            IdPet = idPet;
            Sexo = sexo;
            Raca = raca;
            Peso = peso;
        }

        public int IdPet { get; set; }
        public char Sexo { get; set; }
        public string Raca { get; set; }
        public string Peso { get; set; }
    }
}
