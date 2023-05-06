using Microsoft.EntityFrameworkCore;
using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public class WordStaticRepository : IWordStaticRepository
    {
        private readonly ApplicationDbContext _context;

        public WordStaticRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public  IEnumerable<WordStatistic> GetAll()
        {
            // return  _context.WordStatistics.Include(ws => ws.Player).Include(ws => ws.Word).ToList();
            return _context.WordStatistics.ToList();
        }

        public  WordStatistic GetById(string id)
        {
            return  _context.WordStatistics.Include(ws => ws.Player).Include(ws => ws.Word).FirstOrDefault(ws => ws.Id == id);
        }

        public  void Add(WordStatistic entity)
        {
             _context.WordStatistics.Add(entity);
             _context.SaveChanges();
        }

        public WordStatistic Update(WordStatistic entity)
        {
            _context.WordStatistics.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public  void Delete(string id)
        {
            var wordStatistic =  _context.WordStatistics.Find(id);
            _context.WordStatistics.Remove(wordStatistic);
             _context.SaveChangesAsync();
        }

        public void AddRange(List<WordStatistic> wordsstatistics)
        {
            _context.WordStatistics.AddRange(wordsstatistics);
            _context.SaveChanges();
        }
    }
}
