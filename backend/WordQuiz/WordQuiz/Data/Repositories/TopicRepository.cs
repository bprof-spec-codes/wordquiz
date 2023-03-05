using Microsoft.EntityFrameworkCore;
using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        private readonly ApplicationDbContext _context;

        public TopicRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Topic> GetAllTopics()
        {
            return _context.Topics.Include(t => t.Words).ToList();
        }

        public Topic GetTopicById(string id)
        {
            return _context.Topics.Include(t => t.Words).FirstOrDefault(t => t.Id == id);
        }

        public void AddTopic(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
        }

        public void UpdateTopic(Topic topic)
        {
            _context.Topics.Update(topic);
            _context.SaveChanges();
        }

        public void DeleteTopic(string id)
        {
            var topic = _context.Topics.FirstOrDefault(t => t.Id == id);
            if (topic != null)
            {
                _context.Topics.Remove(topic);
                _context.SaveChanges();
            }
        }
    }
}
