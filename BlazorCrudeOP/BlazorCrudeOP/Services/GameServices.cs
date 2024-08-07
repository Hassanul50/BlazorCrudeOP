using BlazorCrudeOP.Data;
using BlazorCrudeOP.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudeOP.Services
{
    public class GameServices : IGameServices
    {
        private readonly DataContext _dataContext;

        public GameServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Game>> GetAllGames()
        {
            var games = await _dataContext.Games.ToListAsync();
            return games;
        }
    }
}
