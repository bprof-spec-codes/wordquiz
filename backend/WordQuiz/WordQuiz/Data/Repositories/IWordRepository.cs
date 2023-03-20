using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface IWordRepository
    {
        Task<Word> CreateWord(Word word);
        Task DeleteWord(string wordId);
        Task<IEnumerable<Word>> GetAllWords();
        Task<Word> GetWordById(string wordId);
        Task<Word> UpdateWord(Word word);

        Task<IEnumerable<Word>> GetWordsByTopicIdAsync(string topicId);
    }
}