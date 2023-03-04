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



        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<Player> GetPlayerById(string playerId)
        {
            return await _dbContext.Users.FindAsync(playerId);
        }

        public async Task<Player> CreatePlayer(Player player)
        {
            _dbContext.Users.Add(player);
            await _dbContext.SaveChangesAsync();
            return player;
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            _dbContext.Entry(player).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return player;
        }

        public async Task DeletePlayer(string playerId)
        {
            var player = await _dbContext.Users.FindAsync(playerId);
            if (player != null)
            {
                _dbContext.Users.Remove(player);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

}
