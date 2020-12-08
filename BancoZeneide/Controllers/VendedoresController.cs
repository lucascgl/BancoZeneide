using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoZeneide.Models;
using BancoZeneide.Services;
using Microsoft.AspNetCore.Mvc;

namespace BancoZeneide.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete (int? id)
        {
            if (id == null){
                return NotFound();
            }

            var obj = _vendedorService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _vendedorService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}
