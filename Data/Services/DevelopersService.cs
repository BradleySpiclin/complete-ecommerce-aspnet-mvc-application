using eGameStore.Data.Base;
using eGameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Data.Services
{
    public class DevelopersService : EntityBaseRepository<Developer>, IDevelopersService
    {
        public DevelopersService(AppDbContext context) : base(context) { }
    }
}
