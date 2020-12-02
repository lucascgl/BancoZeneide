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

        public DbSet<BancoZeneide.Models.Cliente> Cliente { get; set; }
    }
}
