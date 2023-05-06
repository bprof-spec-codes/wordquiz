using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface ITopicRepository
    {
        Topic AddTopic(Topic topic);
        void DeleteTopic(string id);
        IEnumerable<Topic> GetAllTopics();
        Topic GetTopicById(string id);
        Topic UpdateTopic(Topic topic);
        Topic GetTopicByName(string name);

        void AddRange(List<Topic> topics);

    }
}