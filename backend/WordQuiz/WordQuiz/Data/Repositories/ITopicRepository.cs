using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface ITopicRepository
    {
        Task<Topic> AddTopic(Topic topic);
        Task DeleteTopic(string id);
        Task<IEnumerable<Topic>> GetAllTopics();
        Task<Topic> GetTopicById(string id);
        Task<Topic> UpdateTopic(Topic topic);
    }
}