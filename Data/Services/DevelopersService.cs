using eGameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Data.Services
{
    public class DevelopersService : IDevelopersService
    {
        private readonly AppDbContext _context;

        public DevelopersService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Developer developer)
        {
            await _context.Developer.AddAsync(developer);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var result = await _context.Developer.FirstOrDefaultAsync(x => x.Id == id);
            _context.Developer.Remove(result);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Developer>> GetAllAsync()
        {
            return await _context.Developer.ToListAsync();
        }

        public async Task<Developer> GetByIdAsync(int id)
        {
            var result = await _context.Developer.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<Developer> UpdateAsync(int id, Developer newDeveloper)
        {
            _context.Update(newDeveloper);
            await _context.SaveChangesAsync();
            return newDeveloper;
        }

    }
}
