using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoZeneide.Services;
using Microsoft.AspNetCore.Mvc;

namespace BancoZeneide.Controllers
{
    public class PedidosController : Controller
    {
        private readonly PedidoService _pedidosService;

        public PedidosController(PedidoService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("dd-MM-yyyy");
            ViewData["maxDate"] = minDate.Value.ToString("dd-MM-yyyy");
            var result = await _pedidosService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
            public async Task<IActionResult> GroupingSearchAsync(DateTime? minDate, DateTime? maxDate)
            {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("dd-MM-yyyy");
            ViewData["maxDate"] = minDate.Value.ToString("dd-MM-yyyy");
            var result = await _pedidosService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        }
    }
