using BancoZeneide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Data
{
    public class SeedingService
    {
        private BancoZeneideContext _context;

        public SeedingService(BancoZeneideContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Cliente.Any() || _context.Categoria.Any() || _context.Pedido.Any() || _context.Pet.Any() || _context.Produto.Any() || _context.Vendedor.Any())
            {
                return; // DB has been seeded
            }

            Categoria c1 = new Categoria(1, "Mais Vendidos", "1");
            Categoria c2 = new Categoria(2, "Roupas", "1");
            Categoria c3 = new Categoria(3, "Fantasias", "3");
            Categoria c4 = new Categoria(4, "Bandanas", "2");
            Categoria c5 = new Categoria(5, "Tecidos", "5");

            Vendedor v1 = new Vendedor(1, "Lucas Galvão", "131.190.567.74", new DateTime(2020, 12, 03));
            Vendedor v2 = new Vendedor(1, "Zeneide Coutinho", "000.000.000-00", new DateTime(2020, 12, 03));

            _context.Categoria.AddRange(c1, c2, c3, c4);
            _context.Vendedor.AddRange(v1, v2);

            _context.SaveChanges();
        }
    }

}