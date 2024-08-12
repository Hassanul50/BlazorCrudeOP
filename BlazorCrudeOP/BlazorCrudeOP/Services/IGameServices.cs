using BlazorCrudeOP.Entity;

namespace BlazorCrudeOP.Services
{
    public interface IGameServices
    {
        Task<List<Game>> GetAllGames();
        Task<Game> CreateGame(Game game);
    }
}
