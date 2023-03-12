using Microsoft.EntityFrameworkCore;
using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public class WordStaticRepository : IWordStaticRepository
    {
        private readonly ApplicationDbContext _context;

        public WordStaticRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WordStatistic>> GetAllAsync()
        {
            return await _context.WordStatistics.Include(ws => ws.Player).Include(ws => ws.Word).ToListAsync();
        }

        public async Task<WordStatistic> GetByIdAsync(string id)
        {
            return await _context.WordStatistics.Include(ws => ws.Player).Include(ws => ws.Word).FirstOrDefaultAsync(ws => ws.Id == id);
        }

        public async Task AddAsync(WordStatistic entity)
        {
            await _context.WordStatistics.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WordStatistic entity)
        {
            _context.WordStatistics.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var wordStatistic = await _context.WordStatistics.FindAsync(id);
            _context.WordStatistics.Remove(wordStatistic);
            await _context.SaveChangesAsync();
        }
    }
}
