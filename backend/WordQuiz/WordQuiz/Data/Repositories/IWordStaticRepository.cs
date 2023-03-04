using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface IWordStaticRepository
    {
        Task AddAsync(WordStatistic entity);
        Task DeleteAsync(string id);
        Task<IEnumerable<WordStatistic>> GetAllAsync();
        Task<WordStatistic> GetByIdAsync(string id);
        Task UpdateAsync(WordStatistic entity);
    }
}