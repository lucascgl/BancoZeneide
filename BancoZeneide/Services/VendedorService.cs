﻿using BancoZeneide.Data;
using BancoZeneide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoZeneide.Services
{
    public class VendedorService
    {
        private readonly BancoZeneideContext _context;

        public VendedorService(BancoZeneideContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Vendedor FindById (int id)
        {
            return _context.Vendedor.FirstOrDefault(obj => obj.IdVendedor == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

    }
}
