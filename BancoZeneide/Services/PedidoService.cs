using BancoZeneide.Controllers;
using BancoZeneide.Data;
using BancoZeneide.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Services
{
    public class PedidoService
    {
        private readonly BancoZeneideContext _context;

        public PedidoService(BancoZeneideContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> FindByDateAsync (DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pedido select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataVenda >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataVenda <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .OrderByDescending(x => x.DataVenda)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Categoria, Pedido>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pedido select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataVenda >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataVenda <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .OrderByDescending(x => x.DataVenda)
                .GroupBy (x => x.Categoria)
                .ToListAsync();
        }
    }
}
