using MinimalAPI.Contracts;
using MinimalAPI.Models;

namespace MinimalAPI.Repositories
{
    public interface IItemRepository
    { 
        Task<Item> GetAsync(int Id);
        Task<IEnumerable<Item>> GetAllAsync();
        Task<bool> UpdateAsync(Item item);
        Task<bool> CreateAsync(Item item);
        Task<bool> DeleteAsync(int id);
    }
}
