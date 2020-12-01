using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoZeneide.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoZeneide.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {

            List<Cliente> list = new List<Cliente>();
            list.Add(new Cliente { Id = 1, Nome = "Lucas Galvão", Telefone = "(21) 97257-8266", Email = "lucascgalvao12@gmail.com", Cep = "24804-012" });
            list.Add(new Cliente { Id = 1, Nome = "Zeneide", Telefone = "(21) 97217-8236", Email = "zeneide@gmail.com", Cep = "24804-012" });

            return View(list);
        }
    }
}
