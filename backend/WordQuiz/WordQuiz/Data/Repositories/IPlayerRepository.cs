using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> CreatePlayer(Player player);
        Task DeletePlayer(string playerId);
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(string playerId);
        Task<Player> UpdatePlayer(Player player);
    }
}