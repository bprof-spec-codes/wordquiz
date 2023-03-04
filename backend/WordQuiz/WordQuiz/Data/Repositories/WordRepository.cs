using Microsoft.EntityFrameworkCore;
using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public class WordRepository : IWordRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public WordRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Word>> GetAllWords()
        {
            return await _dbContext.Words.Include(w => w.Topic).ToListAsync();
        }

        public async Task<Word> GetWordById(string wordId)
        {
            return await _dbContext.Words.Include(w => w.Topic).SingleOrDefaultAsync(w => w.Id == wordId);
        }

        public async Task<Word> CreateWord(Word word)
        {
            _dbContext.Words.Add(word);
            await _dbContext.SaveChangesAsync();
            return word;
        }

        public async Task<Word> UpdateWord(Word word)
        {
            _dbContext.Entry(word).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return word;
        }

        public async Task DeleteWord(string wordId)
        {
            var word = await _dbContext.Words.FindAsync(wordId);
            if (word != null)
            {
                _dbContext.Words.Remove(word);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
