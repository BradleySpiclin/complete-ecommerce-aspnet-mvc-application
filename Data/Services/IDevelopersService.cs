using eGameStore.Models;

namespace eGameStore.Data.Services
{
    public interface IDevelopersService
    {
        // Return all Developer objects
        Task<IEnumerable<Developer>> GetAll();

        // CRUD for Developer
        Developer GetById(int id);
        void Add(Developer developer);
        void Update(Developer developer);
        void Delete(int id);
    }
}
