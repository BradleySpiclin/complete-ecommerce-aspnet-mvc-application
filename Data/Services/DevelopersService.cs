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
        public void AddDeveloper(Developer developer)
        {
            throw new NotImplementedException();
        }
        public void DeleteDeveloper(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Developer>> GetAll()
        {
            return await _context.Developer.ToListAsync();
        }

        public Developer GetDeveloperById(int id)
        {
            throw new NotImplementedException();
        }
        public void UpdateDeveloper(Developer developer)
        {
            throw new NotImplementedException();
        }

    }
}
