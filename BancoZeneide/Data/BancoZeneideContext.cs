using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BancoZeneide.Models;

namespace BancoZeneide.Data
{
    public class BancoZeneideContext : DbContext
    {
        public BancoZeneideContext (DbContextOptions<BancoZeneideContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
