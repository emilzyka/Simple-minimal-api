using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MinimalAPI.Database;
using MinimalAPI.Models;

namespace MinimalAPI.Repositories
{
    public class ItemRepository : IItemRepository   
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context) => _context = context;

        public async Task<Item> GetAsync(int Id)
        {
            return await _context.Item.FindAsync(Id);
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Item.ToListAsync();
        }

        public async Task<bool> UpdateAsync(Item item)
        {
            var current = await _context.Item.FindAsync(item.Id);
            _context.ChangeTracker.Clear();
            if(current != null )
            {
                _context.Item.Update(item);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> CreateAsync(Item item)
        {
            await _context.Item.AddAsync(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var current = await _context.Item.FindAsync(id);
            _context.ChangeTracker.Clear();
            if (current != null)
            {
                _context.Item.Remove(current);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
