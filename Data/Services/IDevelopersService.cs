using eGameStore.Models;

namespace eGameStore.Data.Services
{
    public interface IDevelopersService
    {
        // Return all Developer objects
        Task<IEnumerable<Developer>> GetAll();

        // CRUD for Developer
        Developer GetDeveloperById(int id);
        void AddDeveloper(Developer developer);
        void UpdateDeveloper(Developer developer);
        void DeleteDeveloper(int id);
    }
}
