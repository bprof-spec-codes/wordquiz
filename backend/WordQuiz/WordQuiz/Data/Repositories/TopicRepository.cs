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

        public async Task<IEnumerable<Topic>> GetAllTopics()
        {
            return await _context.Topics.Include(t => t.Words).ToListAsync();
        }

        public async Task<Topic> GetTopicById(string id)
        {
            return await _context.Topics.Include(t => t.Words).SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Topic> AddTopic(Topic topic)
        {
            _context.Topics.Add(topic);
            await _context.SaveChangesAsync();
            return topic;
        }

        public async Task<Topic> UpdateTopic(Topic topic)
        {
            _context.Entry(topic).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return topic;
        }

        public async Task DeleteTopic(string id)
        {
            /*
            var topic = _context.Topics.FirstOrDefault(t => t.Id == id);
            if (topic != null)
            {
                _context.Topics.Remove(topic);
                _context.SaveChanges();
            }*/

            var topic = await _context.Words.FindAsync(id);
            if (topic != null)
            {
                _context.Words.Remove(topic);
                await _context.SaveChangesAsync();
            }
        }
    }
}
