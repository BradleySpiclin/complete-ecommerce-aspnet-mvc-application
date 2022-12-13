using eGameStore.Models;

namespace eGameStore.Data.Services
{
    public interface IDevelopersService
    {
        // Return all Developer objects
        Task<IEnumerable<Developer>> GetAllAsync();

        // CRUD for Developer
        Task<Developer> GetByIdAsync(int id);
        Task AddAsync(Developer developer);
        Task<Developer> UpdateAsync(int id, Developer developer);
        Task DeleteAsync(int id);
    }
}
