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
            return _context.Topics
                .Include(t => t.Words)
                .ToList();
        }

        public Topic GetTopicById(string id)
        {
            return _context.Topics.Include(t => t.Words)
                .SingleOrDefault(t => t.Id == id);
        }

        public Topic AddTopic(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
            return topic;
        }

        public Topic UpdateTopic(Topic topic)
        {
            _context.Entry(topic).State = EntityState.Modified;
            _context.SaveChanges();
            return topic;
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

        public Topic GetTopicByName(string name)
        {
            return _context.Topics.Include(t => t.Words)
                .SingleOrDefault(t => t.Title == name);
        }

        public void AddRange(List<Topic> topics)
        {
            _context.AddRange(topics);
            _context.SaveChanges();
        }
    }
}
