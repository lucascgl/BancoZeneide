using BancoZeneide.Data;
using BancoZeneide.Models;
using BancoZeneide.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync (int id)
        {
            return await _context.Vendedor.FirstOrDefaultAsync(obj => obj.IdVendedor == id);
        }

        public async Task RemoveAsync(int id)
        {
            try 
            { 
            var obj = await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não posso deletar o vendedor porque ele(a) tem vendas");
            }
        }

        public async Task UpdateAsync(Vendedor obj)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.IdVendedor == obj.IdVendedor);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
