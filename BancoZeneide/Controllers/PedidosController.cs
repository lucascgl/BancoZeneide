﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BancoZeneide.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
