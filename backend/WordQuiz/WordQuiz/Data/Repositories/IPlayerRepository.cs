using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface IPlayerRepository
    {
        Player CreatePlayer(Player player);
        void DeletePlayer(string playerId);
        IEnumerable<Player> GetAllPlayers();
        Player GetPlayerById(string playerId);
        Player UpdatePlayer(Player player);
        void AddRange(List<Player> playeres);
    }
}