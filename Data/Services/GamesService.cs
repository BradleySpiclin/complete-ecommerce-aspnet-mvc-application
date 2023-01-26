using eGameStore.Data.Base;
using eGameStore.Models;

namespace eGameStore.Data.Services
{
	public class GamesService : EntityBaseRepository<Game>, IGamesService
	{
		public GamesService(AppDbContext context) : base(context) { }
	}
}
