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
        public IEnumerable<Word> GetAllWords()
        {
            return _dbContext.Words.Include(w => w.Topic).ToList();
        }

        public Word GetWordById(string wordId)
        {
            return _dbContext.Words.Include(w => w.Topic).FirstOrDefault(w => w.Id == wordId);
        }

        public Word GetWordByOriginal(string wordOriginal)
        {
            return _dbContext.Words.Include(w => w.Topic).FirstOrDefault(w => w.Original == wordOriginal);
        }

        public List<Word> GetAllWordsByOriginal(string wordOriginal)
        {
            return _dbContext.Words.Include(w => w.Topic).Where(w => w.Original == wordOriginal).ToList();
        }

        public Word GetWordByTranslation(string wordT)
        {
            return _dbContext.Words.Include(w => w.Topic).FirstOrDefault(w => w.Translation == wordT);
        }

        public List<Word> GetAllWordsByTranslation(string wordT)
        {
            return _dbContext.Words.Include(w => w.Topic).Where(w => w.Translation == wordT).ToList();
        }

        public Word CreateWord(Word word)
        {
            _dbContext.Words.Add(word);
            _dbContext.SaveChanges();
            return word;
        }

        public Word UpdateWord(Word word)
        {
            _dbContext.Entry(word).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return word;
        }

        public void DeleteWord(string wordId)
        {
            var word = _dbContext.Words.Find(wordId);
            if (word != null)
            {
                _dbContext.Words.Remove(word);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Word> GetWordsByTopicId(string topicId)
        {
            return _dbContext.Words.Where(w => w.Topic.Id == topicId).ToList();
        }

        public void AddRange(List<Word> words)
        {
            _dbContext.AddRange(words);
            _dbContext.SaveChanges();
        }
    }
}
