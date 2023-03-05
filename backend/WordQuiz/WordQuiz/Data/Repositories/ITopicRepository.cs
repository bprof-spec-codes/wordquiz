using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface ITopicRepository
    {
        void AddTopic(Topic topic);
        void DeleteTopic(string id);
        IEnumerable<Topic> GetAllTopics();
        Topic GetTopicById(string id);
        void UpdateTopic(Topic topic);
    }
}