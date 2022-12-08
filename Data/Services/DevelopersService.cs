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
        public void Add(Developer developer)
        {
            _context.Developer.Add(developer);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Developer>> GetAll()
        {
            return await _context.Developer.ToListAsync();
        }

        public Developer GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Developer developer)
        {
            throw new NotImplementedException();
        }

    }
}
