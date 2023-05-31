using Microsoft.EntityFrameworkCore;
using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PlayerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return _dbContext.Users.ToList();
        }

        public Player GetPlayerById(string playerId)
        {
            return _dbContext.Users.Find(playerId);
        }

        public Player CreatePlayer(Player player)
        {
            _dbContext.Users.Add(player);
            _dbContext.SaveChanges();
            return player;
        }

        public Player UpdatePlayer(Player player)
        {
            _dbContext.Entry(player).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return player;
        }

        public void DeletePlayer(string playerId)
        {
            var player = _dbContext.Users.Find(playerId);
            if (player != null)
            {
                _dbContext.Users.Remove(player);
                _dbContext.SaveChanges();
            }
        }

        public void AddRange(List<Player> playeres)
        {
            _dbContext.AddRange(playeres);
            _dbContext.SaveChanges();
        }
    }

}
