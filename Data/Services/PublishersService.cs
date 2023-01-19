using eGameStore.Data.Base;
using eGameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Data.Services
{
    public class PublishersService : EntityBaseRepository<Publisher>, IPublishersService
    {
        public PublishersService(AppDbContext context) : base(context) { }
    }
}
