using Microsoft.EntityFrameworkCore;
using Backend.Models;
using Backend.Models.Scaffold;
using Backend.DTOs;

namespace Backend.Repositories
{
    public class ProductRepository
    {
        private readonly MySQLDbContext _context;


        public ProductRepository(MySQLDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Producto?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Producto product)
        {

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Producto product)
        {

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var product = await GetByIdAsync(id);
            if (product != null)
            {

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        internal async Task<object> AddAsync(ProductCreateDTO product)
        {
            throw new NotImplementedException();
        }
    }
}

